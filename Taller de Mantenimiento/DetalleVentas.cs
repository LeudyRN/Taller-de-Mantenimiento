using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_de_Mantenimiento
{
    internal class DetalleVentas
    {
        public int id_detalle_venta {  get; set; }

        public int id_venta { get; set; }

        public int id_pieza { get; set; }

        public int id_servicio { get; set; }

        public int cantidad {  get; set; }

        public decimal precio_unitario { get; set; }

        public decimal subtotal { get; set; }
    }
}
