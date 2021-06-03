using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaMaba.Models
{
    public partial class Transaccion
    {
        public string idTrancc { get; set; }
        public int Direccion { get; set; }
        public double precio { get; set; }
        Transaccion(string id, int dir,double pre)
        {
            idTrancc = id;
            Direccion = dir;
            precio =pre;
        }

    }
}
