using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Practica_3
{
    // --------------------------------------------
    // Fernando Torres Vega
    // Curso DAM
    // Modalidad Presencial
    // Práctica nº 3
    // --------------------------------------------
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt_cancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void bt_aceptar_Click(object sender, RoutedEventArgs e)
        {
            if (!EmailCorrecto(tb_correo_electronico.Text))
            {
                MessageBox.Show("El email es incorrecto.", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                tb_correo_electronico.Focus();
                return;
            }

            if (cb_cliente.IsChecked == true)
            {
                if (tb_segundo_apellido.Text != "" && tb_telf2.Text != "")
                {
                    MessageBox.Show("Insert into clientes values('"
                        + tb_nombre.Text + "', '" + tb_primer_apellido.Text + "', '"
                        + tb_segundo_apellido.Text + "', " + tb_telf1.Text + ", "
                        + tb_telf2.Text + ", '" + tb_correo_electronico.Text + "', '"
                        + tb_direccion.Text + "', " + tb_codpos.Text + ", '"
                        + tb_poblacion.Text + "', '" + cb_provincia.Text +
                        "');");
                }
                else if (tb_segundo_apellido.Text == "" && tb_telf2.Text == "")
                {
                    MessageBox.Show("Insert into clientes values('"
                        + tb_nombre.Text + "', '" + tb_primer_apellido.Text + "', "
                        + "null" + ", " + tb_telf1.Text + ", "
                        + "null" + ", '" + tb_correo_electronico.Text + "', '"
                        + tb_direccion.Text + "', " + tb_codpos.Text + ", '"
                        + tb_poblacion.Text + "', '" + cb_provincia.Text +
                        "');");
                }
                else if (tb_segundo_apellido.Text != "")
                {
                    MessageBox.Show("Insert into clientes values('"
                        + tb_nombre.Text + "', '" + tb_primer_apellido.Text + "', '"
                        + tb_segundo_apellido.Text + "', " + tb_telf1.Text + ", "
                        + "null" + ", '" + tb_correo_electronico.Text + "', '"
                        + tb_direccion.Text + "', " + tb_codpos.Text + ", '"
                        + tb_poblacion.Text + "', '" + cb_provincia.Text +
                        "');");
                }
                else
                {
                    MessageBox.Show("Insert into clientes values('"
                        + tb_nombre.Text + "', '" + tb_primer_apellido.Text + "', "
                        + "null" + ", " + tb_telf1.Text + ", "
                        + tb_telf2.Text + ", '" + tb_correo_electronico.Text + "', '"
                        + tb_direccion.Text + "', " + tb_codpos.Text + ", '"
                        + tb_poblacion.Text + "', '" + cb_provincia.Text +
                        "');");
                }
            }
            else
            {
                if (tb_segundo_apellido.Text != "" && tb_telf2.Text != "")
                {
                    MessageBox.Show("Insert into distribuidores values('"
                        + tb_nombre.Text + "', '" + tb_primer_apellido.Text + "', '"
                        + tb_segundo_apellido.Text + "', " + tb_telf1.Text + ", "
                        + tb_telf2.Text + ", '" + tb_correo_electronico.Text + "', '"
                        + tb_direccion.Text + "', " + tb_codpos.Text + ", '"
                        + tb_poblacion.Text + "', '" + cb_provincia.Text +
                        "');");
                }
                else if (tb_segundo_apellido.Text == "" && tb_telf2.Text == "")
                {
                    MessageBox.Show("Insert into distribuidores values('"
                        + tb_nombre.Text + "', '" + tb_primer_apellido.Text + "', "
                        + "null" + ", " + tb_telf1.Text + ", "
                        + "null" + ", '" + tb_correo_electronico.Text + "', '"
                        + tb_direccion.Text + "', " + tb_codpos.Text + ", '"
                        + tb_poblacion.Text + "', '" + cb_provincia.Text +
                        "');");
                }
                else if (tb_segundo_apellido.Text != "")
                {
                    MessageBox.Show("Insert into distribuidores values('"
                        + tb_nombre.Text + "', '" + tb_primer_apellido.Text + "', '"
                        + tb_segundo_apellido.Text + "', " + tb_telf1.Text + ", "
                        + "null" + ", '" + tb_correo_electronico.Text + "', '"
                        + tb_direccion.Text + "', " + tb_codpos.Text + ", '"
                        + tb_poblacion.Text + "', '" + cb_provincia.Text +
                        "');");
                }
                else
                {
                    MessageBox.Show("Insert into distribuidores values('"
                        + tb_nombre.Text + "', '" + tb_primer_apellido.Text + "', "
                        + "null" + ", " + tb_telf1.Text + ", "
                        + tb_telf2.Text + ", '" + tb_correo_electronico.Text + "', '"
                        + tb_direccion.Text + "', " + tb_codpos.Text + ", '"
                        + tb_poblacion.Text + "', '" + cb_provincia.Text +
                        "');");
                }
            }
        }

        private void tb_telf1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void tb_telf2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
        //requerido: nombre, apellido1, telf1, correo, direccion, cliente/distribuidor, codpos, poblacion, provincia
        private void puedo_aceptar()
        {
            bool puedo_aceptar = true;

            if (tb_nombre.Text == "")
            {
                puedo_aceptar = false;
            }
            if (tb_primer_apellido.Text == "")
            {
                puedo_aceptar = false;
            }
            if (cb_cliente.IsChecked == false || cb_cliente.IsChecked == false)
            {
                puedo_aceptar = false;
            }
            if (tb_telf1.Text == "")
            {
                puedo_aceptar = false;
            }
            if (tb_correo_electronico.Text == "")
            {
                puedo_aceptar = false;
            }
            if (tb_codpos.Text == "")
            {
                puedo_aceptar = false;
            }
            if (tb_poblacion.Text == "")
            {
                puedo_aceptar = false;
            }
            if (cb_provincia.SelectedIndex == -1)
            {
                puedo_aceptar = false;
            }
            if (puedo_aceptar == true)
            {
                bt_aceptar.IsEnabled = true;
            }
        }

        private void tb_nombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            puedo_aceptar();
        }

        private void tb_primer_apellido_TextChanged(object sender, TextChangedEventArgs e)
        {
            puedo_aceptar();
        }

        private void tb_telf1_TextChanged(object sender, TextChangedEventArgs e)
        {
            puedo_aceptar();
        }

        private Boolean EmailCorrecto(string email)
        {
            string expresion = "^(([\\w-]+\\.)+[\\w-]+|([a-zA-Z]{1}|[\\w-]{2,}))@(([a-zA-Z]+[\\w-]+\\.){1,2}[a-zA-Z]{2,4})$";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void tb_correo_electronico_TextChanged(object sender, TextChangedEventArgs e)
        {
            puedo_aceptar();
        }

        private void cb_cliente_Checked(object sender, RoutedEventArgs e)
        {
            puedo_aceptar();
            cbi_murcia.IsEnabled = true;
            cbi_albacete.IsEnabled = true;
            cbi_cuenca.IsEnabled = true;
            cbi_teruel.IsEnabled = true;
            cbi_murcia.Visibility = System.Windows.Visibility.Visible;
            cbi_albacete.Visibility = System.Windows.Visibility.Visible;
            cbi_cuenca.Visibility = System.Windows.Visibility.Visible;
            cbi_teruel.Visibility = System.Windows.Visibility.Visible;
        }

        private void cb_distribuidor_Checked(object sender, RoutedEventArgs e)
        {
            puedo_aceptar();
            cbi_murcia.IsEnabled = false;
            cbi_albacete.IsEnabled = false;
            cbi_cuenca.IsEnabled = false;
            cbi_teruel.IsEnabled = false;
            cbi_murcia.Visibility = System.Windows.Visibility.Collapsed;
            cbi_albacete.Visibility = System.Windows.Visibility.Collapsed;
            cbi_cuenca.Visibility = System.Windows.Visibility.Collapsed;
            cbi_teruel.Visibility = System.Windows.Visibility.Collapsed;

        }

        private void cb_provincia_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            puedo_aceptar();
        }

        private void tb_direccion_TextChanged(object sender, TextChangedEventArgs e)
        {
            puedo_aceptar();
        }

        private void tb_codpos_TextChanged(object sender, TextChangedEventArgs e)
        {
            puedo_aceptar();
        }

        private void tb_poblacion_TextChanged(object sender, TextChangedEventArgs e)
        {
            puedo_aceptar();
        }
    }
}
