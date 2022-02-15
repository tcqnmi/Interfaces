using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1__Listas
{
    class Libro
    {
        //Declaramos los atributos de cada libro
        public String portada { get; set; }
        public String titulo { get; set; }
        public String autor { get; set; }
        public String editorial { get; set; }
        public int numPaginas { get; set; }

        //Hacemos un toString de depuración para comprobar
        //que la conexión funciona correctamente
        public override string ToString()
        {
            return string.Format("{0}/{1}",this.titulo,this.autor);
        }

    }
}
