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

namespace M4_Ejercicio_1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //identificamos lo que hemos pulsado como un button con esta referencia
            Button b = sender as Button;
            //comprobamos por si acaso que si se ha podido asociar a un boton
            if (b != null){
                mensaje.Text = "Has pulsado el botón ["+b.Content+"]";
            
            }
        }
    }
}
