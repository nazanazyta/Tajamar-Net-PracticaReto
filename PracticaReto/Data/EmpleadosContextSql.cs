using PracticaReto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PracticaReto.Data
{
    public class EmpleadosContextSql : DbContext, IEmpleadosContext
    {
        public EmpleadosContextSql()
            :base("name=casasqlhospital") { }
        public DbSet<Empleado> Empleados { get; set; }
    }
}