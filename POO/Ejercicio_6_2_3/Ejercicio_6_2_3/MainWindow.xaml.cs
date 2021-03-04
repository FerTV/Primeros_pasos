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

namespace Ejercicio_6_2_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public class Libro
    {
        private string Autor;
        private string Titulo;
        private string Ubicacion;

        public void SetAutor(string Autor)
        {
            this.Autor = Autor;
        }
        public void SetTitulo(string Titulo)
        {
            this.Titulo = Titulo;
        }
        public void SetUbicacion(string Ubicacion)
        {
            this.Ubicacion = Ubicacion;
        }
        public string GetAutor()
        {
            return this.Autor;
        }
        public string GetTitulo()
        {
            return this.Titulo;
        }
        public string GetUbicacion()
        {
            return this.Ubicacion;
        }
    }
    public partial class MainWindow : Window
    {
        Libro Libro1;
        public MainWindow()
        {
            InitializeComponent();

            Libro1 = new Libro();
        }

        private void bt_Introducir_Click(object sender, RoutedEventArgs e)
        {
            Libro1.SetAutor(txt_autor.Text);
            Libro1.SetTitulo(txt_titulo.Text);
            Libro1.SetUbicacion(txt_ubicacion.Text);
        }
        private void bt_titulo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Libro1.GetTitulo());
        }
        private void bt_Autor_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Libro1.GetAutor());
        }

        private void bt_ubicacion_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Libro1.GetUbicacion());
        }
    }
}
