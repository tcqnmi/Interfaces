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

namespace M5_Modelo1_Clientes
{
    /// <summary>
    /// Lógica de interacción para ventanaImprimir.xaml
    /// </summary>
    public partial class ventanaImprimir : Window
    {

        public ClientesMDBDataSet ds { get; set; }
        public ventanaImprimir()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listadoClientes informe = new listadoClientes();
            informe.SetDataSource(ds);
            Visor.ViewerCore.ReportSource =informe;

        }
    }
}
