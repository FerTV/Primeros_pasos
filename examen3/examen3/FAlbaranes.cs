using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen3
{
    public partial class FAlbaranes : Form
    {
        public int Cliente_id { get; set; }
        public FAlbaranes()
        {
            InitializeComponent();
        }

        public FAlbaranes(int cliente_id)
        {
            InitializeComponent();

            Cliente_id = cliente_id;
        }

        private void Recargar(int rowIndex = 0)
        {
            // Instanciamos la clase CAlbaranesBD.
            CAlbaranesBD albaranesBD = new CAlbaranesBD();
            // Recargamos el DataGridView asociando el DataSource con los datos devueltos.
            if (Cliente_id != 0)
            {
                dataGridView.DataSource = albaranesBD.ClienteSeleccionar(Cliente_id);
            }
            else
            {
                dataGridView.DataSource = albaranesBD.Seleccionar();
            }
            // Si tenemos datos...
            if (dataGridView.RowCount > 0)
            {
                // Comprobamos que la fila que nos indican no es superior a la cantidad de filas que tenemos.
                // Si es así, nos posicionamos en la última fila.
                if (rowIndex >= dataGridView.RowCount)
                    rowIndex = dataGridView.RowCount - 1;
                // Si nos indican una fila negativa, nos posicionamos en la primera.
                if (rowIndex < 0)
                    rowIndex = 0;
                // Nos posicionamos en la fila indicada.
                dataGridView.CurrentCell = dataGridView[1, rowIndex];
            }
        }
        private void FAlbaranes_Load(object sender, EventArgs e)
        {
            // Cargamos la tabla de albaranes.
            Recargar();
            // No permitimos que nos inserten filas a través del DataGridView.
            dataGridView.AllowUserToAddRows = false;
            // Las filas de la cabecera las ponemos centradas.
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Ocultamos la columna que muestra la clave primaria "id"
            dataGridView.Columns["albaran_id"].Visible = false;
            dataGridView.Columns["cliente_id"].Visible = false;
            // La columna con los precios la mostramos formateada como moneda (currency)...
            dataGridView.DefaultCellStyle.NullValue = "---";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
