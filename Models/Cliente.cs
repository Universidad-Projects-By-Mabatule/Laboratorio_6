using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaMaba.Models
{
    public partial class Clientes
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Asunto { get; set; }
        public string Email { get; set; }
        public string Comentario { get; set; }
        Clientes(string nom,string dir,string tel,string asu,string ema,string comen)
        {
            Nombre = nom;
            Direccion = dir;
            Telefono = tel;
            Asunto = asu;
            Email = ema;
            Comentario = comen;
        }

    }
}
