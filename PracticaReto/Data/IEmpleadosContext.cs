using PracticaReto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaReto.Data
{
    public interface IEmpleadosContext
    {
        DbSet<Empleado> Empleados { get; set; }
    }
}
