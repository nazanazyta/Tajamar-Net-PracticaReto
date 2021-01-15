using PracticaReto.Data;
using PracticaReto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaReto.Repositories
{
    public class RepositoryEmpleados : IRepositoryEmpleados
    {
        IEmpleadosContext context;

        public RepositoryEmpleados(IEmpleadosContext context)
        {
            this.context = context;
        }
        public List<Empleado> GetEmpleados()
        {
            return this.context.Empleados.ToList();
        }
    }
}