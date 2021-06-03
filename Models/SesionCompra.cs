using System;
using System.Collections.Generic;
using System.Text;
namespace EmpresaMaba.Models
{
    class SesionCompra
    {

        public  void sesionCompre(Clientes cliente)
        {
            Clientes.Comprar();

        }
        public long comprar(Item it, int unidades,Transaccion tran)
        {
            int price;
            price = it.(unidades) -(unidades * descuento(tran));
            return price; 
        }
        public float descuento(Transaccion tran)
        {
            return tran.precio;
        }
 
        
    }
}
