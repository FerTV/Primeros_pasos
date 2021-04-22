using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicio_8_1_1_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StreamWriter fichero;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fichero = new StreamWriter("fichero.txt");
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            fichero.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtTexto.Text.ToLower() == "fin")
            {
                Close();
                return;
            }

            fichero.WriteLine(txtTexto.Text);
            txtTexto.Text = "";
            txtTexto.Focus();
        }
    }
}
