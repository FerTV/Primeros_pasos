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
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            FClientes fClientes = new FClientes();

            fClientes.ShowDialog();
        }

        private void btn_albaranes_Click(object sender, EventArgs e)
        {
            FAlbaranes fAlbaranes = new FAlbaranes();

            fAlbaranes.ShowDialog();
        }
    }
}
