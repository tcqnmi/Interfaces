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

namespace M5_Modelo1_Clientes
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

            M5_Modelo1_Clientes.ClientesMDBDataSet clientesMDBDataSet = ((M5_Modelo1_Clientes.ClientesMDBDataSet)(this.FindResource("clientesMDBDataSet")));
            // Cargar datos en la tabla Clientes. Puede modificar este código según sea necesario.
            M5_Modelo1_Clientes.ClientesMDBDataSetTableAdapters.ClientesTableAdapter clientesMDBDataSetClientesTableAdapter = new M5_Modelo1_Clientes.ClientesMDBDataSetTableAdapters.ClientesTableAdapter();
            clientesMDBDataSetClientesTableAdapter.Fill(clientesMDBDataSet.Clientes);
            System.Windows.Data.CollectionViewSource clientesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clientesViewSource")));
            clientesViewSource.View.MoveCurrentToFirst();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Creamos la ventana de impresión
            //Conectamos los datos de la ventana actual (data grid )con la de impresión
            ventanaImprimir ventana = new ventanaImprimir();
            ventana.ds = ((M5_Modelo1_Clientes.ClientesMDBDataSet)(this.FindResource("clientesMDBDataSet")));
            ventana.ShowDialog();
        }
    }
}
