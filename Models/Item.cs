using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaMaba.Models
{
    public partial class Item
    {
        public string Nombre { get; set; }
        public int Unidades { get; set; }
        public double Precio { get; set; }
        Item(string nom,int uni,double prec)
        {
            Nombre = nom;
            Unidades = uni;
            Precio =prec;
        }

    }
}
