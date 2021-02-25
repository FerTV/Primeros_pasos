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

namespace Ejemplo1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, RoutedEventArgs e)
        {
            if(cb_estudias.IsChecked==true) //para verificar que esta checkeado
                Close();
            if (cb_trabajas.IsChecked == true) //para verificar que esta checkeado
                Close();
        }

        private void txt_nombre_GotFocus(object sender, RoutedEventArgs e)
        {
            txt_nombre.Background = Brushes.White;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            /*
          PARA ESTO HAY QUE USAR LA LIBRERIA System.Windows.Forms;
          if (System.Windows.MessageBox.Show("¿Seguro que quieres continuar?",
                           "Confirma, por favor",
                           MessageBoxButton.YesNo,
                           MessageBoxImage.Question,
                           (MessageBoxResult)MessageBoxDefaultButton.Button1) ==
                           MessageBoxResult.Yes)
           */

            var result = MessageBox.Show("¿Seguro que quieres continuar?",
                            "Confirma, por favor",
                            MessageBoxButton.YesNo,
                            MessageBoxImage.Question);

            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cb_provincias_DropDownClosed(object sender, EventArgs e)
        {
            MessageBox.Show(cb_provincias.Text+ " - SelectedItem: " + Convert.ToString(cb_provincias.SelectedIndex));
        }

        private void b_provincias_Click(object sender, RoutedEventArgs e)
        {
            if(cb_provincias.SelectedIndex!=-1)
            {
                MessageBox.Show(cb_provincias.Text);
            }
        }

        private void cb_provincias_KeyUp(object sender, KeyEventArgs e)
        {
            btn_Salir.IsEnabled = true;
            if(e.Key==Key.Back)
            {
                if (cb_provincias.Text == "")
                    btn_Salir.IsEnabled = false;
            }
        }

        private void rb_coche_Click(object sender, RoutedEventArgs e)
        {
            cb_provincias.SelectedIndex = -1;
            cb_provincias.Text = "";
            cb_provincias.IsEnabled = false;
        }

        private void rb_moto_Checked(object sender, RoutedEventArgs e)
        {
            cb_provincias.IsEnabled = true;
        }
    }
}