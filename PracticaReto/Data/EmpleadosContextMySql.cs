using MySql.Data.Entity;
using PracticaReto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PracticaReto.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EmpleadosContextMySql: DbContext, IEmpleadosContext
    {
        public EmpleadosContextMySql()
            : base("name=casamysqlhospital") { }
        public DbSet<Empleado> Empleados { get; set; }
    }
}