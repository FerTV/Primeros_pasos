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
    public partial class FClientesModificar : Form
    {
        public int Cliente_id { get; set; }
        public FClientesModificar(int cliente_id = 0)
        {
            InitializeComponent();

            Cliente_id = cliente_id;
        }

        private void FClientesModificar_Load(object sender, EventArgs e)
        {
            // Si me indican un producto en concreto, es que queremos modificarlo.
            if (Cliente_id != 0)
            {
                // Instanciamos la clase CClientesBD.
                CClientesBD clientesBD = new CClientesBD();

                // Buscamos el cliente.
                clientesBD.Seleccionar(Cliente_id);
                // Mostramos la clave primaria.
                txtId.Text = Convert.ToString(clientesBD.Cliente_id);
                // El nombre del cliente.
                txtNombre.Text = clientesBD.Nombre;
                // El nifcif del cliente.
                txtNifcif.Text = clientesBD.Nifcif;
                // El email del cliente.
                txtEmail.Text = clientesBD.Email;
                //El teléfono del cliente.
                txtTelefono.Text = clientesBD.Telefono;
                // Indicamos que estamos modificando.
                Text = "Clientes :: Modificar";
            }
            else
            {
                Text = "Clientes :: Insertar";
            }
        }

        private bool Correcto()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe indicar el Nombre del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            if (txtNifcif.Text == "")
            {
                MessageBox.Show("Debe indicar el Nif/Cif del cliente",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNifcif.Focus();
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Debe indicar el Email del cliente",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Debe indicar el Teléfono del cliente",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Verificamos que todo es correcto antes de proseguir.
            if (!Correcto())
                return;
            // Por defecto, indicamos que se pulsa el botón OK.
            //DialogResult = DialogResult.OK;
            // Instanciamos la clase CClienteBD.
            CClientesBD clientesBD = new CClientesBD();
            // Le pasamos a cada una de las propiedades los valores correspondientes.
            clientesBD.Nombre = txtNombre.Text;
            clientesBD.Nifcif = txtNifcif.Text;
            clientesBD.Email = txtEmail.Text;
            clientesBD.Telefono = txtTelefono.Text;
            // Si estamos insertando...
            if (Cliente_id == 0)
            {
                // Insertamos y verificamos que todo ha ido bien.
                if (clientesBD.Insertar())
                {
                    Cliente_id = clientesBD.Cliente_id;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Al insertar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Si no se ha podido insertar, devolvemos Cancel.
                    //DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                // y sino, estamos modificando.
                // Indicamos el cliente a modificar.
                clientesBD.Cliente_id = Cliente_id;
                // Verificamos que si ha habido un error.
                if (!clientesBD.Modificar())
                {
                    MessageBox.Show("Al modificar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Si no se ha podido modificar, devolvemos Cancel.
                    //DialogResult = DialogResult.Cancel;
                }
                else
                    DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
