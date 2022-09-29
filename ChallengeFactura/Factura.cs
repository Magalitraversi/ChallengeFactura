using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeFactura
{
     public class Factura
    {
    
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Paciente { get; set; }
        public string Servicios { get; set; }
        public double Importe { get; set; }
        public string Total { get { return string.Format("{0}$ ", Importe * 1); } }
    }
}
