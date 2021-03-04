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

namespace Ejercicio_6_3_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CLibro libro;
        public MainWindow()
        {
            InitializeComponent();

            libro = new CLibro();
        }

        private void bt_introducir_datos_Click(object sender, RoutedEventArgs e)
        {
            libro.SetAutor(txt_autor.Text);
            libro.SetTitulo(txt_titulo.Text);
            libro.SetUbicacion(txt_ubicacion.Text);
        }

        private void bt_titulo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(libro.GetTitulo());
        }

        private void bt_autor_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(libro.GetAutor());
        }

        private void bt_ubicacion_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(libro.GetUbicacion());
        }
    }
}
