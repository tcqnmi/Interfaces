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

namespace Trabajo_1_Evaluacion_2
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Trabajo_1_Evaluacion_2.PeliculasDataSet peliculasDataSet = ((Trabajo_1_Evaluacion_2.PeliculasDataSet)(this.FindResource("peliculasDataSet")));
            // Cargar datos en la tabla Pelicula. Puede modificar este código según sea necesario.
            Trabajo_1_Evaluacion_2.PeliculasDataSetTableAdapters.PeliculaTableAdapter peliculasDataSetPeliculaTableAdapter = new Trabajo_1_Evaluacion_2.PeliculasDataSetTableAdapters.PeliculaTableAdapter();
            peliculasDataSetPeliculaTableAdapter.Fill(peliculasDataSet.Pelicula);
            System.Windows.Data.CollectionViewSource peliculaViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("peliculaViewSource")));
            peliculaViewSource.View.MoveCurrentToFirst();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VentaImpresion ventana = new VentaImpresion();
            ventana.ds = ((Trabajo_1_Evaluacion_2.PeliculasDataSet)(this.FindResource("peliculasDataSet")));
            ventana.ShowDialog();
        }
    }
}
