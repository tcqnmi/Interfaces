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
using System.Windows.Shapes;

namespace Trabajo_1_Evaluacion_2
{
    /// <summary>
    /// Lógica de interacción para VentaImpresion.xaml
    /// </summary>
    public partial class VentaImpresion : Window
    {

        public PeliculasDataSet ds { get; set; }
        public VentaImpresion()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listadoPeliculas informe = new listadoPeliculas();
            informe.SetDataSource(ds);
            Visor.ViewerCore.ReportSource = informe;
        }
    }
}
