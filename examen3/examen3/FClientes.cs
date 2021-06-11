using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// --------------------------------------------
// Fernando Torres Vega
// Curso DAM
// Modalidad Presencial
// Examen 3ª evaluación
// --------------------------------------------

namespace examen3
{
    public partial class FClientes : Form
    {
        public FClientes()
        {
            InitializeComponent();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            // Miramos en qué fila nos encontramos.
            // Si no tenemos filas, nos posicionamos en la primera (0).
            // En caso contrario, en la fila actual del DataGridView.
            // Observar la utilidad, en este caso, del operador ternario. Más limpio que utilizar un if.
            int rowIndex = (dataGridView.RowCount == 0) ? 0 : dataGridView.CurrentRow.Index;
            // Otra forma de mirar en qué fila nos encontramos sería con un if.
            //
            // int rowIndex = 0;
            //
            // if (dataGridView.RowCount > 0)
            // rowIndex = dataGridView.CurrentRow.Index;
            // Llamamos al procedimiento recargar y nos posicionamos en la fila actual.
            Recargar(rowIndex);
        }
        private void Recargar(int rowIndex = 0)
        {
            // Instanciamos la clase CClientesBD.
            CClientesBD clientesBD = new CClientesBD();
            // Recargamos el DataGridView asociando el DataSource con los datos devueltos.
            dataGridView.DataSource = clientesBD.Seleccionar();
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
        private void FClientes_Load(object sender, EventArgs e)
        {
            // Cargamos la tabla de clientes.
            Recargar();
            // No permitimos que nos inserten filas a través del DataGridView.
            dataGridView.AllowUserToAddRows = false;
            // Las filas de la cabecera las ponemos centradas.
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Ocultamos la columna que muestra la clave primaria "id"
            dataGridView.Columns["cliente_id"].Visible = false;
            // Si hay algún valor null, lo mostraremos con tres guiones.
            dataGridView.DefaultCellStyle.NullValue = "---";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Instanciamos la clase FClientesModificar para introducir los datos.
            FClientesModificar fClientesModificar = new FClientesModificar();
            // Mostramos el cuadro de diálogo.
            fClientesModificar.ShowDialog();
            // Si se ha pulsado el botón de aceptar.
            if (fClientesModificar.DialogResult == DialogResult.OK)
            {
                // Recargamos la tabla.
                Recargar();
                // Obtenemos la clave primaria del cliente insertado.
                int cliente_id = fClientesModificar.Cliente_id;
                // Buscamos la fila del cliente insertado.
                int rowIndex = dataGridView.Rows
                               .Cast<DataGridViewRow>()
                               .Where(r => r.Cells[0].Value.Equals(cliente_id))
                               .First()
                               .Index;

                // Nos posicionamos en ella.
                dataGridView.CurrentCell = dataGridView[1, rowIndex];
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Si tenemos registros en la tabla.
            if (dataGridView.RowCount > 0)
            {
                // Obtenemos la clave primaria del cliente.
                int cliente_id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
                // Instanciamos la clase FClientesModificar para modificar los datos.
                // Observar que le pasamos en el contructor la clave primaria.
                FClientesModificar fClientesModificar = new FClientesModificar(cliente_id);
                // Mostramos el cuadro de diálogo.
                fClientesModificar.ShowDialog();
                // Si se ha pulsado el botón de aceptar.
                if (fClientesModificar.DialogResult == DialogResult.OK)
                {
                    // Recargamos la tabla.
                    Recargar();
                    // Buscamos la fila del cliente editado.
                    int rowIndex = dataGridView.Rows
                                   .Cast<DataGridViewRow>()
                                   .Where(r => r.Cells[0].Value.Equals(cliente_id))
                                   .First()
                                   .Index;

                    // Nos posicionamos en ella.
                    dataGridView.CurrentCell = dataGridView[1, rowIndex];
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Si tenemos registros en la tabla y...
            // el usuario me confirma que realmente quiere borrar el registro.
            if ((dataGridView.RowCount > 0) &&
            (MessageBox.Show("¿Realmente quiere borrar el cliente seleccionado?",
            "Confirmación",
           MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes))
            {
                // Creamos una instancia de la clase CClientesBD.
                CClientesBD clientesBD = new CClientesBD();
                // Obtenemos la clave principal del cliente a borrar.
                clientesBD.Cliente_id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
                // Si el producto se borra correctamente.
                if (clientesBD.Borrar())
                {
                    // Obtenemos la fila actual.
                    int rowIndex = dataGridView.CurrentCell.RowIndex;
                    // Recargamos y vamos a la fila actual, que corresponderá al siguiente producto.
                    Recargar(rowIndex);
                }
                else
                    // Sino se ha podido borrar, mensaje de error.
                    MessageBox.Show("Al borrar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlbaranes_Click(object sender, EventArgs e)
        {
            int cliente_id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);

            FAlbaranes fAlbaranes = new FAlbaranes(cliente_id);

            fAlbaranes.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Si el usuario realmente quiere salir, cerramos la app.
            if (MessageBox.Show("¿Realmente quiere salir de la App?",
            "Confirmación", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
