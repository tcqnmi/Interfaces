using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Ej3_Inmobiliaria
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<Casa> lista = new ObservableCollection<Casa>();

            lista.Add(new Casa {

                foto = "/imgs/casa1.jpg",
                direccion="direccion1",
                precio = 200000,
                dormitorios=3,
                baños=2,
                metrosCuadrados = 300,

            }) ;

            lista.Add(new Casa {
                foto = "/imgs/casa2.jpg",
                direccion = "direccion2",
                precio = 90000,
                dormitorios = 2,
                baños = 2,
                metrosCuadrados = 200,

            });

            lista.Add(new Casa
            {
                foto = "/imgs/casa3.jpg",
                direccion = "direccion3",
                precio = 350000,
                dormitorios = 3,
                baños = 3,
                metrosCuadrados = 290,

            });

            lstLista.ItemsSource = lista;

        }
    }
}
