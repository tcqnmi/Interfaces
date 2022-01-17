using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2_NBA
{
    class Partidos
    {
        //No necesitamos un constructor
        //prop [tab][tab]
        public String Logo1 { get; set; }
        //Encapsula un atributo privado y los métodos getter y setter

        public String Logo2 { get; set; }

        public int Puntos1 { get; set; }

        public int Puntos2 { get; set; }

        public String Equipo1 { get; set; }

        public String Equipo2 { get; set; }

        //ponemos el to string a modo de mera comprobación previa al asociar la 
        //lista a la plantilla antes de darle el formato deseado
        public override string ToString()
        {
            return this.Equipo1 + " / " + this.Equipo2;
        }
    }
}
