using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francisco.Modelos
{
    public class Ingrediente
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int PuntoPedidoMinimo { get; set; }
        public int Precio { get; set; }
    }
}
