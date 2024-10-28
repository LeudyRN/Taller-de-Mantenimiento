using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_de_Mantenimiento
{
    internal class Orden
    {

        public int id_orden { get; set; }
        public int id_vehiculo { get; set; }
        public DateTime fecha { get; set; }  
        public string estado { get; set; }
        public decimal total { get; set; } 

    }
}
