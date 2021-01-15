using PracticaReto.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaReto.Controllers
{
    public class EmpleadosController : Controller
    {
        IRepositoryEmpleados repo;

        public EmpleadosController(IRepositoryEmpleados repo)
        {
            this.repo = repo;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListaEmpleados()
        {
            return View(this.repo.GetEmpleados());
        }
    }
}