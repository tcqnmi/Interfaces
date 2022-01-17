using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_ComboBox
{
    class Distribucion
    {

        //Datos de una distribución Linux
        public String Logo { get; set; }
        public String Nombre { get; set; }
        public double Tamaño { get; set; }
        public double Version { get; set; }

        //Explícitamente hay que indicar que estamos sobreescribiendo el metodo
        public override string ToString()
        {
            return this.Nombre+" | "+this.Tamaño;
        }
    }
}
