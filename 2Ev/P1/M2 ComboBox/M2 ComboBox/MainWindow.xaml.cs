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

namespace M2_ComboBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Carga de trabajo. Lista de objetos de Distribución
            ObservableCollection<Distribucion> lista = new ObservableCollection<Distribucion>();


            lista.Add(new Distribucion { Logo = "imgs/128_mint.png", Nombre = "Linux Mint", Tamaño = 3.8, Version = 21.04 });
            lista.Add(new Distribucion { Logo = "imgs/128_raspios.png", Nombre = "Linux Rapsberry", Tamaño = 5.2, Version = 30.03 });
            lista.Add(new Distribucion { Logo = "imgs/128_ubuntu.png", Nombre = "Linux Ubuntu", Tamaño = 4.1, Version = 14.00 });
            lista.Add(new Distribucion { Logo = "imgs/128_redhat_black.png", Nombre = "Linux Red Hat", Tamaño = 5.8, Version = 11 });

            lstCombo.ItemsSource = lista;

        }
    }
}
