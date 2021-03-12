using System.Windows;

namespace Ejercicio_6_4_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CPersona persona;
        CPersonaInglesa personaInglesa;
        public MainWindow()
        {
            InitializeComponent();

            persona = new CPersona();
            personaInglesa = new CPersonaInglesa();
        }

        private void bt_introducir_Click(object sender, RoutedEventArgs e)
        {
            persona.SetNombre(txt_persona.Text);
            personaInglesa.SetNombre(txt_persona_inglesa.Text);
        }

        private void bt_acciones_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(persona.Saludar());
            MessageBox.Show(personaInglesa.Saludar() + " " + personaInglesa.TomarTe());
        }
    }
}
