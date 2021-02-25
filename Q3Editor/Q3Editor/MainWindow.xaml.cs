using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace Q3Editor
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool guardado = false;
        public MainWindow()
        {
            InitializeComponent();

            guardado = true;

            RoutedCommand Ctrl_N = new RoutedCommand();
            Ctrl_N.InputGestures.Add(new KeyGesture(Key.N, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_N, m_archivo_nuevo_Click));

            RoutedCommand Ctrl_A = new RoutedCommand();
            Ctrl_A.InputGestures.Add(new KeyGesture(Key.A, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_A, m_archivo_abrir_Click));

            RoutedCommand Ctrl_G = new RoutedCommand();
            Ctrl_G.InputGestures.Add(new KeyGesture(Key.G, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_G, m_archivo_Guardar_Click));

            RoutedCommand Ctrl_I = new RoutedCommand();
            Ctrl_I.InputGestures.Add(new KeyGesture(Key.I, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_I, m_archivo_imprimir_Click));

            RoutedCommand Alt_F4 = new RoutedCommand();
            Alt_F4.InputGestures.Add(new KeyGesture(Key.F4, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Alt_F4, m_archivo_Guardar_Click));

            m_contenido.Focus();
        }

        private void m_archivo_salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void m_archivo_nuevo_Click(object sender, RoutedEventArgs e)
        {
            Guardar();

            m_contenido.Clear();
        }

        private void Guardar()
        {
            if (m_contenido.Text != "" && !guardado)
            {
                if(MessageBox.Show("¿Quiere guardar el contenido?",
                                   "Confirmación",
                                   MessageBoxButton.YesNo,
                                   MessageBoxImage.Question)
                                    == MessageBoxResult.Yes)
                {
                    MessageBox.Show("Guardando...");

                    guardado = true;
                }
            }
        }

        private void m_archivo_abrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if(openFileDialog.ShowDialog() == true)
            {
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    m_contenido.Text = reader.ReadToEnd();
                }

                panelNombre.Content = openFileDialog.FileName;

                guardado = true;

                panelEstado.Content = "Guardado";
            }
        }

        private void m_window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Guardar();
        }

        private void m_archivo_Guardar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void m_archivo_imprimir_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
