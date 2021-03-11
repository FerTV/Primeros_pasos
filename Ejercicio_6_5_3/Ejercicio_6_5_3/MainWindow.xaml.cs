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

namespace Ejercicio_6_5_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CLibro Libro;
        public MainWindow()
        {
            InitializeComponent();

            Libro = new CLibro();
        }

        private void bt_introducir_datos_Click(object sender, RoutedEventArgs e)
        {
            Libro.SetAutor(txt_autor.Text);
            Libro.SetTitulo(txt_titulo.Text);
            Libro.SetUbicacion(txt_ubicacion.Text);
            Libro.SetPaginas(Convert.ToInt32(txt_paginas.Text));
        }

        private void bt_titulo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Libro.GetTitulo());
        }

        private void bt_autor_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Libro.GetAutor());
        }

        private void bt_ubicacion_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Libro.GetUbicacion());
        }

        private void bt_paginas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Convert.ToString(Libro.GetPaginas()));
        }
    }
}
