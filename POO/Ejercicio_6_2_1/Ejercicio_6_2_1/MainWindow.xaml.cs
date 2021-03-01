using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicio_6_2_1
{
    public class Persona
    {
        private string nombre;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void Saludar()
        {
            MessageBox.Show("Hola soy "+ nombre);
        }
    }
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        Persona persona1;
        Persona persona2;
        
        public MainWindow()
        {
            InitializeComponent();

            persona1 = new Persona();
            persona2 = new Persona();
        }

        private void bt_saludar_Click(object sender, RoutedEventArgs e)
        {
            persona1.Saludar();
            persona2.Saludar();
        }

        private void bt_asignar_nombre_Click(object sender, RoutedEventArgs e)
        {
            persona1.SetNombre(txt_nombre_persona1.Text);
            persona2.SetNombre(txt_nombre_persona2.Text);
        }
    }
}
