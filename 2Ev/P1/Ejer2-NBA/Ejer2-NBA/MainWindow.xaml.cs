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

namespace Ejer2_NBA
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Debemos escribirlo nosortros e importar posteriormenete la libreria ObjectModel
            
            //Creamos una lista de objetos partido
            ObservableCollection<Partidos> lista = new ObservableCollection<Partidos>();

            //Añadimos datos por código
            lista.Add(new Partidos
            {
                Logo1 = "imgs/BostonCeltics.gif",
                Equipo1 = "Celtics",
                Puntos1 = 109,
                Logo2 = "imgs/ChicagoBulls.gif",
                Equipo2 = "Bulls",
                Puntos2 = 95,
            });

            lista.Add(new Partidos
            {
                Logo1 = "imgs/BrooklynNets.gif",
                Equipo1 = "Nets",
                Puntos1 = 129,
                Logo2 = "imgs/DallasMavericks.gif",
                Equipo2 = "Maverics",
                Puntos2 = 130,
            });

            lista.Add(new Partidos
            {
                Logo1 = "imgs/DenverNuggets.gif",
                Equipo1 = "Nuggets",
                Puntos1 = 90,
                Logo2 = "imgs/MiamiHeat.gif",
                Equipo2 = "Heats",
                Puntos2 = 106,
            });

            lista.Add(new Partidos
            {
                Logo1 = "imgs/TorontoRaptors.gif",
                Equipo1 = "Raptors",
                Puntos1 = 107,
                Logo2 = "imgs/ChicagoBulls.gif",
                Equipo2 = "Bulls",
                Puntos2 = 106,
            });
            //Enlaza la lista de partidos con el control (plantilla)
            lstLista.ItemsSource = lista;
        }
    }
}
