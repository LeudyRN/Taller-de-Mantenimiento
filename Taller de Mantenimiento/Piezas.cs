using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_de_Mantenimiento
{
    internal class Piezas
    {
        public int id_pieza { get; set; }
        public string nombre_pieza { get; set; }
        public string descripcion_pieza { get; set; }
        public int precio { get; set; }
        public int cantidad_disponible { get; set; }
    }
}
