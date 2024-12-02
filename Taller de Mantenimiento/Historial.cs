using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_de_Mantenimiento
{
    internal class Historial
    {
        public int id_historial { get; set; }

        public string tabla_modificada { get; set; }

        public int id_registro { get; set; }

        public string tipo_operacion { get; set; }

        public string usuario { get; set; }

        public DateTime fecha { get; set; }

        public string valores_anteriores { get; set; }

        public string valores_nuevos { get; set; }
    }
}
