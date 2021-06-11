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
    class CAlbaranesBD : CConexionBD
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
        public int Albaran_id { get; set; }
        public int Cliente_id { get; set; }
        public Char Serie { get; set; }
        public int Numero { get; set; }
        public String Fecha { get; set; }
        public double Importe { get; set; }
        // Propiedad que devuelve el error producido.
        // Al poner solo "get", le indicamos que es de lectura.
        public String Error { get { return sError; } }

        public DataTable Seleccionar(int albaran_id = 0)
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
                sqlCommand.CommandText = "AlbaranesSeleccionar";

                // Parámetro pasado al procediento almacenado.
                sqlCommand.Parameters.AddWithValue("@albaran_id", albaran_id);

                // Ejecutamos la sentencia...
                sqlDataReader = sqlCommand.ExecuteReader();
                // y la guardamos en la tabla leída en la memoria.
                dataTable.Load(sqlDataReader);
                // Si me indicaron que seleccionase un único registro y este existe.
                if ((albaran_id != 0) && (dataTable.Rows.Count != 0))
                {
                    // Obtenemos las filas de la tabla en memoria (En este sólo hay una única fila).
                    DataRow[] rows = dataTable.Select();
                    // Asignamos a cada propiedad del nombre el valor del registro leído.
                    Albaran_id = albaran_id;
                    Cliente_id = Convert.ToInt32(rows[0]["cliente_id"].ToString());
                    Serie = Convert.ToChar(rows[0]["serie"].ToString());
                    Numero = Convert.ToInt32(rows[0]["numero"].ToString());
                    Fecha = rows[0]["fecha"].ToString();
                    Importe = Convert.ToDouble(rows[0]["importe"].ToString());
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

        public DataTable ClienteSeleccionar(int cliente_id = 0)
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
                sqlCommand.CommandText = "AlbaranesClienteSeleccionar";

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
                    Serie = Convert.ToChar(rows[0]["serie"].ToString());
                    Numero = Convert.ToInt32(rows[0]["numero"].ToString());
                    Fecha = rows[0]["fecha"].ToString();
                    Importe = Convert.ToDouble(rows[0]["importe"].ToString());
                    Cliente_id = cliente_id;
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
    }
}
