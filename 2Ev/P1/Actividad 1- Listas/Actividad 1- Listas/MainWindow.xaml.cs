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

namespace Actividad_1__Listas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<Libro> listaLibros = new ObservableCollection<Libro>();

            listaLibros.Add(new Libro 
            {
                portada = "imgs/acotar.jpg",
                titulo = "Una corte de rosas y espinas",
                autor = "Sarah J. Mass",
                editorial = "Planeta",
                numPaginas = 452,
            });

            listaLibros.Add(new Libro
            {
                portada = "imgs/frankenstein.jpg",
                titulo = "Frankenstein",
                autor = "Mary Shelley",
                editorial = "Alma Clásicos",
                numPaginas = 320,
            });

            listaLibros.Add(new Libro
            {
                portada = "imgs/gotico.jpg",
                titulo = "Gótico",
                autor = "Silvia Moreno García",
                editorial = "Nocturna",
                numPaginas = 360,
            });

            listaLibros.Add(new Libro
            {
                portada = "imgs/laNoviaGitana.jpg",
                titulo = "La novia gitana",
                autor = "Carmen Mola",
                editorial = "Alfagura",
                numPaginas = 408,
            });

            listaLibros.Add(new Libro
            {
                portada = "imgs/reinaRoja.jpg",
                titulo = "Reina roja",
                autor = "Juan Gomez Jurado",
                editorial = "Ediciones B",
                numPaginas = 568,
            });

            listaLibros.Add(new Libro
            {
                portada = "imgs/encuadernador.jpg",
                titulo = "El encuadernador",
                autor = "Bridget Collins",
                editorial = "Plaza & Janes Editores",
                numPaginas = 480,
            });

            lstLibros.ItemsSource = listaLibros;
        }
    }
}
