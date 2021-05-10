using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CRUD
{
    class CCategoriasBD
    {
        private CConexionBD conexionBD = new CConexionBD();
        private SqlCommand sqlCommand = new SqlCommand();
        private SqlDataReader sqlDataReader;
        public int Categoria_id { get; set; }
        public String Categoria { get; set; }
        public DataTable Seleccionar(int categoria_id = 0)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conexionBD.Abrir();
                sqlCommand.Connection = conexionBD.Connection;
                sqlCommand.CommandType = CommandType.Text;
                // Si me indicaron que tenía que obtener todas las categorías, ...
                if (categoria_id == 0)
                    sqlCommand.CommandText = "SELECT * FROM categorias ORDER BY categoria ASC";
                else
                    // En caso contrario solo una categoría.
                    sqlCommand.CommandText = "SELECT * FROM categorias WHERE categoria_id=" + categoria_id;
                sqlDataReader = sqlCommand.ExecuteReader();
                dataTable.Load(sqlDataReader);
                if ((categoria_id != 0) && (dataTable.Rows.Count != 0))
                {
                    DataRow[] rows = dataTable.Select();
                    Categoria_id = categoria_id;
                    Categoria = rows[0]["categoria"].ToString();
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
            try
            {
                // Es similar a la selección, salvo la sentencia SQL.
                conexionBD.Abrir();
                sqlCommand.Connection = conexionBD.Connection;

                sqlCommand.CommandType = CommandType.Text;
                // Observar que hemos utilizado Format para construir la sentencia.
                // El producto se ha puesto entre comillas ('{2}'), porque es una cadena.
                // En el Precio hay que cambiar la coma (,) por un punto (.) para poder guardarlo en la tabla.
                sqlCommand.CommandText =
                string.Format("INSERT INTO categorias VALUES ({0})",Categoria);
                // Ejecutamos la sentencia, indicando que no es una consulta SELECT, y
                // aprovechamos el número de regisros que nos devuelve. En este caso debe ser 1.
                bInsertada = sqlCommand.ExecuteNonQuery() == 1;
                // Si la inserción fue correcta, obtenemos el valor de la clave primaria.
                if (bInsertada)
                {
                    Categoria_id = UltimoId();
                }
            }
            finally
            {
                conexionBD.Cerrar();
            }
            // Devolvemos si la operación fue correcta o no.
            return bInsertada;
        }
        private int UltimoId()
        {
            int ultimo_id = 0;
            try
            {
                // Esta sentencia obtiene el último producto insertado.
                sqlCommand.CommandText = "SELECT @@IDENTITY as ultimo_id";
                sqlDataReader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(sqlDataReader);
                DataRow[] rows = dataTable.Select();
                // Obtenemos la clave primaria del último producto insertado.
                ultimo_id = Convert.ToInt32(rows[0]["ultimo_id"].ToString());
            }
            finally
            {
                sqlDataReader.Close();
            }
            return ultimo_id;
        }
    }
}
