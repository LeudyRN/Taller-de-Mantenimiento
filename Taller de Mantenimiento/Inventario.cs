using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_de_Mantenimiento
{
    internal class Inventario
    {
        public int id_inventario { get; set; }
        public int id_pieza { get; set; }
        public int cantidad { get; set; }
        public string ubicacion { get; set; }
    }
}
