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

namespace Ejercicio_6_3_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CPersona persona1;
        CPersona persona2;
        public MainWindow()
        {
            InitializeComponent();

            persona1 = new CPersona();
            persona2 = new CPersona();
        }

        private void bt_introducir_personas_Click(object sender, RoutedEventArgs e)
        {
            persona1.SetNombre(txt_persona1.Text);
            persona2.SetNombre(txt_persona2.Text);
        }

        private void bt_saludar_Click(object sender, RoutedEventArgs e)
        {
            persona1.Saludar();
            persona2.Saludar();
        }
    }
}
