using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_de_Mantenimiento
{
    internal class Detalle
    {
        public int id_detalle { get; set; }

        public int id_orden { get; set; }

        public int id_servicio { get; set; }

        public decimal subtotal { get; set; }

        public string descripcion_servicio { get; set; }
    }
}
