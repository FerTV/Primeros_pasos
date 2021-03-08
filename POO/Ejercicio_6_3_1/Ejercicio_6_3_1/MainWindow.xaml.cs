using System;
using System.Windows;

namespace Ejercicio_6_3_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CPruerta puerta;
        public MainWindow()
        {
            InitializeComponent();

            puerta = new CPruerta();
        }
        private void bt_guardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                puerta.SetAncho(Convert.ToInt32(txt_ancho.Text));
                puerta.SetAlto(Convert.ToInt32(txt_alto.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
