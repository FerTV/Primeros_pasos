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

namespace Ejercicio_6_4_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CPuerta puerta;
        CPorton porton;
        public MainWindow()
        {
            InitializeComponent();

            puerta = new CPuerta();
            porton = new CPorton();
        }

        private void bt_guardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                porton.SetAncho(Convert.ToInt32(txt_ancho_porton.Text));
                porton.SetAlto(Convert.ToInt32(txt_alto_porton.Text));
                porton.SetColor(Convert.ToInt32(txt_color_porton.Text));
                puerta.SetAncho(Convert.ToInt32(txt_ancho.Text));
                puerta.SetAlto(Convert.ToInt32(txt_alto.Text));
                puerta.SetColor(Convert.ToInt32(txt_color.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void rb_abierta_Click(object sender, RoutedEventArgs e)
        {
            puerta.Abrir();
        }
        private void rb_cerrada_Click(object sender, RoutedEventArgs e)
        {
            puerta.Cerrar();
        }
        private void bt_mostrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Puerta: \n" + 
                            puerta.MostrarEstado() +
                            "\nPorton: \n" +
                            porton.MostrarEstado());
        }
        private void rb_abierta_porton_Click(object sender, RoutedEventArgs e)
        {
            porton.Abrir();
        }
        private void rb_cerrada_porton_Click(object sender, RoutedEventArgs e)
        {
            porton.Cerrar();
        }
    }
}
