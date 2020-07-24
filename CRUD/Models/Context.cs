using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class Context : DbContext
    {

        public Context() : base("ContextConnection")
        {

        }


        public DbSet<ActivoFijo> ActivoFijo { get; set;}
        public DbSet<AsientoContable> AsientoContable { get; set;}
        public DbSet<CalculoDepreciacion> CalculoDepreciacion { get; set;}
        public DbSet<Departamento> Departamento { get; set;}
        public DbSet<Empleado> Empleado { get; set;}
        public DbSet<TipoActivo> TipoActivo { get; set;}
    }
}