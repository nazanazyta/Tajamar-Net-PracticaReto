using PracticaReto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaReto.Repositories
{
    public interface IRepositoryEmpleados
    {
        List<Empleado> GetEmpleados();
    }
}
