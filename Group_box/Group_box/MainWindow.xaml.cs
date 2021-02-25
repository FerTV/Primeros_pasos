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

namespace Group_box
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

        private void bt_salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void menu_archivo_guardar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Guardado");
        }

        private void menu_archivo_nuevo_proyecto_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Abriendo proyecto");
        }

        private void mItem1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has pulsado mItem1");
        }

        private void mItem2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has pulsado mItem2");
        }

        private void mItem3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has pulsado mItem3");
        }

        private void btnFacturar_Click(object sender, RoutedEventArgs e)
        {
            int registros = 50000;

            pbFacturacion.Maximum = registros;
            pbFacturacion.Minimum = 0;
            pbFacturacion.Value = 0;

            for(int i=0;i<registros;i++)
            {
                //Facturación
                pbFacturacion.Value++;
            }
        }

        private void rb_coche_Click(object sender, RoutedEventArgs e)
        {
            cb_provincia.Items.Clear();

            ComboBoxItem cbiPlaceholder = new ComboBoxItem();

            cbiPlaceholder.Content = "-- Elige un coche --";
            cbiPlaceholder.IsEnabled = false;
            cbiPlaceholder.IsSelected = true;

            cb_provincia.Items.Add(cbiPlaceholder);

            cb_provincia.Items.Add("Toyota");
            cb_provincia.Items.Add("Audi");
            cb_provincia.Items.Add("Honda");
        }

        private void cb_moto_Click(object sender, RoutedEventArgs e)
        {
            cb_provincia.Items.Clear();

            ComboBoxItem cbiPlaceholder = new ComboBoxItem();

            cbiPlaceholder.Content = "-- Elige una moto --";
            cbiPlaceholder.IsEnabled = false;
            cbiPlaceholder.IsSelected = true;

            cb_provincia.Items.Add(cbiPlaceholder);

            cb_provincia.Items.Add("Kawasaki");
            cb_provincia.Items.Add("KTM");
            cb_provincia.Items.Add("Honda");
        }

        private void cb_camion_Click(object sender, RoutedEventArgs e)
        {
            cb_provincia.Items.Clear();

            ComboBoxItem cbiPlaceholder = new ComboBoxItem();

            cbiPlaceholder.Content = "-- Elige un camión --";
            cbiPlaceholder.IsEnabled = false;
            cbiPlaceholder.IsSelected = true;

            cb_provincia.Items.Add(cbiPlaceholder);

            cb_provincia.Items.Add("Mercedes");
            cb_provincia.Items.Add("Man");
            cb_provincia.Items.Add("Honda");
        }
    }
}
