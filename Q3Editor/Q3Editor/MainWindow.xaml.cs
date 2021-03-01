//using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;

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

            RoutedCommand Ctrl_O = new RoutedCommand();
            Ctrl_O.InputGestures.Add(new KeyGesture(Key.O, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_O, m_archivo_abrir_Click));

            RoutedCommand Ctrl_S = new RoutedCommand();
            Ctrl_S.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_S, m_archivo_Guardar_Click));

            RoutedCommand Ctrl_P = new RoutedCommand();
            Ctrl_P.InputGestures.Add(new KeyGesture(Key.P, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_P, m_archivo_imprimir_Click));

            RoutedCommand Alt_F4 = new RoutedCommand();
            Alt_F4.InputGestures.Add(new KeyGesture(Key.F4, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Alt_F4, m_archivo_Guardar_Click));

            RoutedCommand Ctrl_X = new RoutedCommand();
            Ctrl_X.InputGestures.Add(new KeyGesture(Key.X, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_X, m_editar_cortar_Click));

            RoutedCommand Ctrl_C = new RoutedCommand();
            Ctrl_C.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_C, m_editar_copiar_Click));

            RoutedCommand Ctrl_V = new RoutedCommand();
            Ctrl_V.InputGestures.Add(new KeyGesture(Key.V, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_V, m_editar_pegar_Click));

            RoutedCommand Ctrl_B = new RoutedCommand();
            Ctrl_B.InputGestures.Add(new KeyGesture(Key.B, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_B, m_fuente_negrita_Click));

            RoutedCommand Ctrl_K = new RoutedCommand();
            Ctrl_K.InputGestures.Add(new KeyGesture(Key.K, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_K, m_fuente_cursiva_Click));

            RoutedCommand Ctrl_U = new RoutedCommand();
            Ctrl_U.InputGestures.Add(new KeyGesture(Key.U, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_U, m_fuente_subrayado_Click));

            RoutedCommand Ctrl_Mas = new RoutedCommand();
            Ctrl_Mas.InputGestures.Add(new KeyGesture(Key.Add, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_Mas, m_fuente_Aumentar_tam_Click));

            RoutedCommand Ctrl_Menos = new RoutedCommand();
            Ctrl_Menos.InputGestures.Add(new KeyGesture(Key.Subtract, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(Ctrl_Menos, m_fuente_Disminuir_tam_Click));

            m_contenido.Focus();
        }

        private void m_archivo_salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void m_archivo_nuevo_Click(object sender, RoutedEventArgs e)
        {
            SeGuarda();

            m_contenido.Clear();
        }

        private MessageBoxResult ConfirmacionBox(string texto)
        {
            return System.Windows.MessageBox.Show(texto, "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }

        private void SeGuarda()
        {
            if (m_contenido.Text != "" && !guardado)
            {
                /*
                if(MessageBox.Show("¿Quiere guardar el contenido?",
                                   "Confirmación",
                                   MessageBoxButton.YesNo,
                                   MessageBoxImage.Question)
                                    == MessageBoxResult.Yes)
                */
                if (ConfirmacionBox("¿Desea guardar el texto?") == MessageBoxResult.Yes)
                {
                    /*
                    MessageBox.Show("Guardando...");

                    guardado = true;
                    */
                    Guardar();
                }
            }
        }

        private void m_archivo_abrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            openFileDialog.InitialDirectory = path;
            openFileDialog.Filter = "txt files (*.txt)|*.|Todos los archivos (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Declaro una variable de tipo fichero
                var fileStream = openFileDialog.OpenFile();

                //Creo un canal de lectura
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    // Rellenamos el textbox con el contenido del fichero
                    m_contenido.Text = reader.ReadToEnd();
                }

                //Alternativa simple
                //txt.Texto
                panelNombre.Content = openFileDialog.FileName;

                //Indico que está guardado
                guardado = true;

                panelEstado.Content = "Guardado";
            }
        }

        private void m_window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SeGuarda();
        }

        private void m_archivo_Guardar_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Guardar()
        {
            //Si no esta guardado ...
            if (!guardado)
            {
                //Si no tiene nombre
                if (panelNombre.Content.ToString() == "<Sin nombre>")
                {
                    GuardarComo();
                }
                else
                {
                    //Lo guardamos en el fichero
                    File.WriteAllText(panelNombre.Content.ToString(), m_contenido.Text);

                    //Se guarda el texto
                    guardado = true;

                    //Indicamos que se ha guardado
                    panelEstado.Content = "Guardado";
                }
            }
        }

        private void m_archivo_imprimir_Click(object sender, RoutedEventArgs e)
        {
            Guardar();
        }

        private void GuardarComo()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            saveFileDialog.InitialDirectory = path;
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = false;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Indicamos el nombre
                panelNombre.Content = saveFileDialog.FileName;

                //Lo guardamos en el fichero
                File.WriteAllText(panelNombre.Content.ToString(), m_contenido.Text);

                //Se guarda el texto
                guardado = true;

                //Indicamos que se ha guardado
                panelEstado.Content = "Guardado";
            }
        }

        private void m_archivo_Guardar_como_Click(object sender, RoutedEventArgs e)
        {
            GuardarComo();
        }

        private void m_contenido_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if(guardado==true)
            {
                //Cada vez que el texto cambie indicaremos que hay que guardarlo
                guardado = false;

                panelEstado.Content = "No guardado";
            }
        }

        private void m_editar_cortar_Click(object sender, RoutedEventArgs e)
        {
            //Si tengo seleccionado, lo cortamos
            if(m_contenido.SelectedText != "")
            {
                m_contenido.Cut();
            }
        }

        private void m_editar_copiar_Click(object sender, RoutedEventArgs e)
        {
            //Si tengo texto seleccionado, lo copiamos
            if(m_contenido.SelectionLength > 0)  //Esto es más rapido que compararlo con cadena vacía
            {
                m_contenido.Copy();
            }
        }

        private void m_editar_pegar_Click(object sender, RoutedEventArgs e)
        {
            //Pegamos directamente
            m_contenido.Paste();
        }

        private void m_fuente_negrita_Click(object sender, RoutedEventArgs e)
        {
            //Si el menú "FuenteNegrita" está chequeado...
            if(m_fuente_negrita.IsChecked)
            {
                m_contenido.FontWeight = FontWeights.Normal;

                m_fuente_negrita.IsChecked = false;
            }
            else
            {
                //Ponemos la fuente en negrita
                m_contenido.FontWeight = FontWeights.Bold;

                m_fuente_negrita.IsChecked = true;
            }
        }

        private void m_fuente_cursiva_Click(object sender, RoutedEventArgs e)
        {
            //Si el menu "FuenteCursiva" está chequeado...
            if (m_fuente_cursiva.IsChecked)
            {
                m_contenido.FontStyle = FontStyles.Normal;

                m_fuente_cursiva.IsChecked = false;
            }
            else
            {
                //Ponemos la fuente en negrita
                m_contenido.FontStyle = FontStyles.Italic;

                m_fuente_cursiva.IsChecked = true;
            }
        }

        private void m_fuente_subrayado_Click(object sender, RoutedEventArgs e)
        {
            //Si el menu "FuenteCursiva" está chequeado...
            if (m_fuente_subrayado.IsChecked)
            {
                m_contenido.TextDecorations = null;

                m_fuente_subrayado.IsChecked = false;
            }
            else
            {
                //Ponemos la fuente en negrita
                m_contenido.TextDecorations = TextDecorations.Underline;

                m_fuente_subrayado.IsChecked = true;
            }
        }

        private void m_fuente_Aumentar_tam_Click(object sender, RoutedEventArgs e)
        {
            m_contenido.FontSize++;
        }

        private void m_fuente_Disminuir_tam_Click(object sender, RoutedEventArgs e)
        {
            if(m_contenido.FontSize >1)
            {
                m_contenido.FontSize--;
            }
        }

        private void m_fuentes_Click(object sender, RoutedEventArgs e)
        {
            var fontDialog = new FontDialog();

            fontDialog.ShowDialog();

            System.Drawing.Font font = fontDialog.Font;

            m_contenido.FontFamily = new System.Windows.Media.FontFamily(font.Name);
            m_contenido.FontSize = font.Size;
            m_contenido.FontWeight = font.Bold ? FontWeights.Bold : FontWeights.Regular;
            m_contenido.FontStyle = font.Italic ? FontStyles.Italic : FontStyles.Normal;

            TextDecorationCollection tdc = new TextDecorationCollection();

            if(fontDialog.Font.Underline)
            {
                tdc.Add(TextDecorations.Underline);
            }
            if(fontDialog.Font.Strikeout)
            {
                tdc.Add(TextDecorations.Strikethrough);
            }

            m_contenido.TextDecorations = tdc;
        }
    }
}
