using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_de_Mantenimiento
{
    internal class Ventas
    {
        public int id_venta { get; set; }

        public int id_cliente { get; set; }

        public DateTime fecha { get; set; }

        public decimal total { get; set; }

        public string metodo_pago { get; set; }
    }
}
