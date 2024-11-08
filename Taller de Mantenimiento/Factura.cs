using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_de_Mantenimiento
{
    internal class Factura
    {
        public int id_factura { get; set; }

        public int id_orden { get; set; }

        public DateTime fecha { get; set; }

        public decimal total { get; set; }
    }
}
