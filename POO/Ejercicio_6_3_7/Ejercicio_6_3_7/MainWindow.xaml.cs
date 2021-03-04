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

namespace Ejercicio_6_3_7
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CCoche coche;
        public MainWindow()
        {
            InitializeComponent();

            coche = new CCoche();
        }

        private void tb_introducir_datos_Click(object sender, RoutedEventArgs e)
        {
            coche.SetCilindrada(Convert.ToInt32(txt_cilindrada.Text));
            coche.SetMarca(txt_marca.Text);
            coche.SetModelo(txt_modelo.Text);
            coche.SetPotencia(Convert.ToInt32(txt_potencia));
        }

        private void tb_mostrar_datos_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Los datos son: \n" +
                            "Marca: " + coche.GetMarca() + "\n" +
                            "Modelo: " + coche.GetModelo() + "\n" +
                            "Cilindrada: " + coche.GetCilindrada() + "\n" +
                            "Potencia: " + coche.GetPotencia() + "\n");
        }
    }
}
