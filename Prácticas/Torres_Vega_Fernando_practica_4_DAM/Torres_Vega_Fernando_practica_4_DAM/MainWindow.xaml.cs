using System.IO;
using System.Windows;

namespace Torres_Vega_Fernando_practica_4_DAM
{
    // --------------------------------------------
    // Fernando Torres Vega
    // Curso DAM
    // Modalidad Presencial
    // Práctica nº 4
    // --------------------------------------------
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btIntroducir_Click(object sender, RoutedEventArgs e)
        {
            string linea;
            string ruta;
            string[] provincia = { "" };

            ruta = txtFichero.Text;//Ruta del fichero de extracción de datos

            try
            {
                using (StreamReader ficherol = new StreamReader(@ruta))//Abro el fichero en modo lectura
                {
                    do
                    {
                        linea = ficherol.ReadLine();//Leo la línea

                        if (linea != null)
                        {
                            provincia = linea.Split('#');//Obtengo provincia de la línea

                            if (provincia[2] == "Alicante")
                            {
                                using (StreamWriter ficheroR = new StreamWriter("Alicante.txt", true))
                                {
                                    ficheroR.WriteLine(linea);//Escribo en el fichero de los clientes de Alicante
                                }                             
                            }
                            else if (provincia[2] == "Valencia")
                            {
                                using (StreamWriter ficheroR = new StreamWriter("Valencia.txt", true))
                                {                 
                                    ficheroR.WriteLine(linea);//Escribo en el fichero de los clientes de Valencia
                                }
                            }
                            else if (provincia[2] == "Castellón")
                            {
                                using (StreamWriter ficheroR = new StreamWriter("Castellón.txt", true))
                                {
                                    ficheroR.WriteLine(linea);//Escribo en el fichero de los clientes de Castellón
                                }                             
                            }
                        }
                    } while (linea != null);//Leo hasta el final del fichero
                    MessageBox.Show("Los datos han sido introducidos");
                }
            }
            catch (PathTooLongException error)
            {
                MessageBox.Show(error.Message);//Lanzo una excepción si la ruta del archivo es demasiado larga
            }
            catch (IOException error)
            {
                MessageBox.Show(error.Message);//Lanzo una excepción si se encuentra algún error con el fichero
            }
            catch (System.ArgumentException error)
            {
                MessageBox.Show(error.Message);//Lanzo una excepción si no se introduce ninguna ruta
            }
        }

        private void bt_salir_Click(object sender, RoutedEventArgs e)
        {
            Close();//Cierro el programa
        }
    }
}
