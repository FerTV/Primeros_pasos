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

namespace Ejercicio_6_7_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CPersona Persona;
        CPersonaInglesa PersonaInglesa1;
        CPersonaInglesa PersonaInglesa2;
        CPersonaItaliana PersonaItaliana;
        public MainWindow()
        {
            InitializeComponent();

            // string nombre="Fer";
            Persona = new CPersona();
            //PersonaInglesa1 = new CPersonaInglesa();
            // PersonaInglesa2 = new CPersonaInglesa(nombre);
            PersonaItaliana = new CPersonaItaliana();
        }

        private void bt_introducir_Click(object sender, RoutedEventArgs e)
        {
            Persona.SetNombre(txt_persona.Text);
            //PersonaInglesa1.SetNombre(txt_persona_inglesa1.Text);
            //PersonaInglesa2.SetNombre(txt_persona_inglesa2.Text);
            string nombre1, nombre2;
            nombre1 = txt_persona_inglesa1.Text;
            PersonaInglesa1 = new CPersonaInglesa(nombre1);
            nombre2 = txt_persona_inglesa2.Text;
            PersonaInglesa2 = new CPersonaInglesa(nombre2);
            PersonaItaliana.SetNombre(txt_persona_italiana.Text);
        }

        private void bt_acciones_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Persona.Saludar());
            MessageBox.Show(PersonaInglesa1.Saludar() + " " + PersonaInglesa1.TomarTe());
            MessageBox.Show(PersonaInglesa2.Saludar() + " " + PersonaInglesa2.TomarTe());
            MessageBox.Show(PersonaItaliana.Saludar());
        }
    }
}
