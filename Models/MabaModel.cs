using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaMaba.Models
{
    public Practica_PatronesEntities()
            : base("name=Practica_PatronesEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Clientes> Clientes { get; set; }
}
