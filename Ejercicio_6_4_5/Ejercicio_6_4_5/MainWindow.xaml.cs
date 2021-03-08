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

namespace Ejercicio_6_4_5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CCoche coche;
        CMoto moto;
        public MainWindow()
        {
            InitializeComponent();

            coche = new CCoche();
            moto = new CMoto();
        }

        private void tb_introducir_datos_coche_Click(object sender, RoutedEventArgs e)
        {
            coche.SetCilindrada(Convert.ToInt32(txt_cilindrada_coche.Text));
            coche.SetMarca(txt_marca_coche.Text);
            coche.SetModelo(txt_modelo_coche.Text);
            coche.SetPotencia(Convert.ToInt32(txt_potencia_coche.Text));
        }

        private void tb_mostrar_datos_coche_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Los datos del coche son: \n" +
                           "Marca: " + coche.GetMarca() + "\n" +
                           "Modelo: " + coche.GetModelo() + "\n" +
                           "Cilindrada: " + coche.GetCilindrada() + "\n" +
                           "Potencia: " + coche.GetPotencia() + "\n");
        }

        private void tb_introducir_datos_moto_Click(object sender, RoutedEventArgs e)
        {
            moto.SetCilindrada(Convert.ToInt32(txt_cilindrada_coche.Text));
            moto.SetMarca(txt_marca_coche.Text);
            moto.SetModelo(txt_modelo_coche.Text);
            moto.SetPotencia(Convert.ToInt32(txt_potencia_coche.Text));
        }

        private void tb_mostrar_datos_moto_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Los datos de la moto son: \n" +
                           "Marca: " + moto.GetMarca() + "\n" +
                           "Modelo: " + moto.GetModelo() + "\n" +
                           "Cilindrada: " + moto.GetCilindrada() + "\n" +
                           "Potencia: " + moto.GetPotencia() + "\n");
        }
    }
}
