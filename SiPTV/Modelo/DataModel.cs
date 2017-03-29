using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiPTV.Modelo
{
    class DataModel:DbContext

{
    public DataModel() : base("DataModel")
    {

    }

    public virtual DbSet<Producto> productos { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
}
