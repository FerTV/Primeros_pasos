using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

// --------------------------------------------
// Fernando Torres Vega
// Curso DAM
// Modalidad Presencial
// Examen 3ª evaluación
// --------------------------------------------

namespace examen3
{
    class CClientesBD : CConexionBD
    {
        // Para realizar la conexión a la base de datos.
        private CConexionBD conexionBD = new CConexionBD();
        // Para ejecutar un procedimiento almacenado o realizar las sentencias SQL.
        private SqlCommand sqlCommand = new SqlCommand();
        // Para almacenar los datos de una sentencia SELECT.
        private SqlDataReader sqlDataReader;
        // Variable privada para indicar el error que se ha producido.
        private String sError;
        // Propiedades para almacenar los datos de un registro de la tabla.
        public int Cliente_id { get; set; }
        public String Nombre { get; set; }
        public String Nifcif { get; set; }
        public String Email { get; set; }
        public String Telefono { get; set; }
        // Propiedad que devuelve el error producido.
        // Al poner solo "get", le indicamos que es de lectura.
        public String Error { get { return sError; } }

        public DataTable Seleccionar(int cliente_id = 0)
        {
            // Para almacenar la tabla leída en memoria.
            DataTable dataTable = new DataTable();
            try
            {
                // Realizamos la conexión.
                conexionBD.Abrir();
                sqlCommand.Connection = conexionBD.Connection;
                // Indicamos el tipo de comando. En este caso un procedimiento almacenado.
                sqlCommand.CommandType = CommandType.StoredProcedure;

                // Sentencia a ejecutar. En este caso un procedimiento almacenado.
                sqlCommand.CommandText = "ClientesSeleccionar";

                // Parámetro pasado al procediento almacenado.
                sqlCommand.Parameters.AddWithValue("@cliente_id", cliente_id);

                // Ejecutamos la sentencia...
                sqlDataReader = sqlCommand.ExecuteReader();
                // y la guardamos en la tabla leída en la memoria.
                dataTable.Load(sqlDataReader);
                // Si me indicaron que seleccionase un único registro y este existe.
                if ((cliente_id != 0) && (dataTable.Rows.Count != 0))
                {
                    // Obtenemos las filas de la tabla en memoria (En este sólo hay una única fila).
                    DataRow[] rows = dataTable.Select();
                    // Asignamos a cada propiedad del nombre el valor del registro leído.
                    Cliente_id = cliente_id;
                    Nombre = rows[0]["nombre"].ToString();
                    Nifcif = rows[0]["nifcif"].ToString();
                    Email = rows[0]["email"].ToString();
                    Telefono = rows[0]["telefono"].ToString();
                }
            }
            catch (Exception ex)
            {
                sError = ex.Message;
            }
            finally
            {
                // Limpiamos los parámetros del comando ejecutado.
                sqlCommand.Parameters.Clear();
                // Cerramos los datos leídos.
                sqlDataReader.Close();
                // Cerramos la conexión.
                conexionBD.Cerrar();
            }

            // Devolvemos la tabla almacenada en memoria.
            return dataTable;
        }

        public bool Insertar()
        {
            // Para devolver si la operación se hizo correctamente, o no.
            bool bInsertada = false;
            sError = "";
            try
            {
                // Es similar a la selección, salvo cambiando el procedimiento almacenado y
                // añadiendo los parámetros correspondientes.
                conexionBD.Abrir();
                sqlCommand.Connection = conexionBD.Connection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ClientesInsertar";
                sqlCommand.Parameters.AddWithValue("@nombre", Nombre);
                sqlCommand.Parameters.AddWithValue("@nifcif", Nifcif);
                sqlCommand.Parameters.AddWithValue("@email", Email);
                sqlCommand.Parameters.AddWithValue("@telefono", Telefono);

                // Valor devuelto por el procedimiento almacenado (En este caso la clave primaria).
                var returnParameter = sqlCommand.Parameters.Add("@cliente_id", SqlDbType.Int);

                // Indicamos que es un valor de sólo retorno.
                returnParameter.Direction = ParameterDirection.ReturnValue;
                // Ejecutamos la sentencia, indicando que no es una consulta SELECT, y
                // aprovechamos el número de registros que nos devuelve. En este caso debe ser 1.
                bInsertada = sqlCommand.ExecuteNonQuery() == 1;
                // Si la inserción fue correcta, obtenemos el valor de la clave primaria.
                if (bInsertada)
                    Cliente_id = Convert.ToInt32(returnParameter.Value);
            }
            catch (Exception ex)
            {
                sError = ex.Message;
                bInsertada = false;
            }
            finally
            {
                // Limpiar parámetros. Haced esto siempre para que no se acumule en
                // la siguiente llamada a un procedimiento almacenado.
                sqlCommand.Parameters.Clear();
                conexionBD.Cerrar();
            }
            // Devolvemos si la operación fue correcta o no.
            return bInsertada;
        }

        public bool Borrar()
        {
            bool bBorrada = false;
            try
            {
                conexionBD.Abrir();
                sqlCommand.Connection = conexionBD.Connection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ClientesBorrar";
                sqlCommand.Parameters.AddWithValue("@cliente_id", Cliente_id);
                bBorrada = sqlCommand.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
                bBorrada = false;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
                conexionBD.Cerrar();
            }
            return bBorrada;
        }

        public bool Modificar()
        {
            bool bModificada = false;
            sError = "";
            try
            {
                conexionBD.Abrir();
                sqlCommand.Connection = conexionBD.Connection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ClientesEditar";
                sqlCommand.Parameters.AddWithValue("@cliente_id", Cliente_id);
                sqlCommand.Parameters.AddWithValue("@nombre", Nombre);
                sqlCommand.Parameters.AddWithValue("@nifcif", Nifcif);
                sqlCommand.Parameters.AddWithValue("@email", Email);
                sqlCommand.Parameters.AddWithValue("@telefono", Telefono);
                bModificada = sqlCommand.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
                bModificada = false;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
                conexionBD.Cerrar();
            }
            return bModificada;
        }
    }
}
