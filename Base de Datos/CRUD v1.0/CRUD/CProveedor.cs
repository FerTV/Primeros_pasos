using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CRUD
{
    class CProveedor : CConexionBD
    {
        private CConexionBD conexionBD = new CConexionBD();
        private SqlCommand sqlCommand = new SqlCommand();
        private SqlDataReader sqlDataReader;

        private String sError;
        public int Proveedor_id{ get; set; }
        public String Nombre { get; set; }
        public String Direccion {get; set; }
        public String Ciudad { get; set; }
        public String Telefono { get; set; }
        public int Codpos { get; set; }
        public String Email { get; set; }
        public String Error { get { return sError; } }

        public DataTable Seleccionar(int proveedor_id = 0)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conexionBD.Abrir();
                sqlCommand.Connection = conexionBD.Connection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ProveedoresSeleccionar";
                sqlCommand.Parameters.AddWithValue("@proveedor_id", proveedor_id);
                sqlDataReader = sqlCommand.ExecuteReader();
                dataTable.Load(sqlDataReader);
                if ((proveedor_id != 0) && (dataTable.Rows.Count != 0))
                {
                    DataRow[] rows = dataTable.Select();
                    Proveedor_id = proveedor_id;
                    Nombre = rows[0]["nombre"].ToString();
                    Direccion = rows[0]["dirección"].ToString();
                    Telefono = rows[0]["telefono"].ToString();
                    Codpos = Convert.ToInt32(rows[0]["codigo postal"]);
                    Email = rows[0]["email"].ToString();
                }
            }
            finally
            {
                sqlCommand.Parameters.Clear();
                sqlDataReader.Close();
                conexionBD.Cerrar();
            }
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
                sqlCommand.CommandText = "ProveedoresInsertar";
                sqlCommand.Parameters.AddWithValue("@proveedor_id", Proveedor_id);
                sqlCommand.Parameters.AddWithValue("@nombre", Nombre);
                sqlCommand.Parameters.AddWithValue("@ciudad", Ciudad);
                sqlCommand.Parameters.AddWithValue("@telefono", Telefono);
                sqlCommand.Parameters.AddWithValue("@codpos", Codpos);
                sqlCommand.Parameters.AddWithValue("@email", Email);

                // Valor devuelto por el procedimiento almacenado (En este caso la clave primaria).
                var returnParameter = sqlCommand.Parameters.Add("@proveedor_id", SqlDbType.Int);

                // Indicamos que es un valor de sólo retorno.
                returnParameter.Direction = ParameterDirection.ReturnValue;
                // Ejecutamos la sentencia, indicando que no es una consulta SELECT, y
                // aprovechamos el número de registros que nos devuelve. En este caso debe ser 1.
                bInsertada = sqlCommand.ExecuteNonQuery() == 1;
                // Si la inserción fue correcta, obtenemos el valor de la clave primaria.
                if (bInsertada)
                    Proveedor_id = Convert.ToInt32(returnParameter.Value);
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
                sqlCommand.CommandText = "ProveedoresBorrar";
                sqlCommand.Parameters.AddWithValue("@proveedor_id", Proveedor_id);
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

        public bool Editar()
        {
            bool bEditada = false;
            sError = "";
            try
            {
                conexionBD.Abrir();
                sqlCommand.Connection = conexionBD.Connection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ProveedoresEditar";
                sqlCommand.Parameters.AddWithValue("@proveedor_id", Proveedor_id);
                sqlCommand.Parameters.AddWithValue("@nombre", Nombre);
                sqlCommand.Parameters.AddWithValue("@ciudad", Ciudad);
                sqlCommand.Parameters.AddWithValue("@telefono", Telefono);
                sqlCommand.Parameters.AddWithValue("@codpos", Codpos);
                sqlCommand.Parameters.AddWithValue("@email", Email);
                bEditada = sqlCommand.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
                bEditada = false;
            }
            finally
            {
                sqlCommand.Parameters.Clear();
                conexionBD.Cerrar();
            }
            return bEditada;
        }
    }
}
