using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using innovationGroup.ApplicationManager.Models;
using System.Data.SqlClient;
using Repository;
using ModelsDb;

namespace innovationGroup.ApplicationManager.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
          
           
            return View();
        }

        //Get
        public IActionResult registro()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registro(Registros mod)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    Repo r = new Repo();
                    mod.FabricanteId = "1";
                    mod.TipoId = "1";
                    r.Registrar(mod);
                    ViewBag.Msg = "Registro feito com sucesso!";
                }

            }
            catch (SqlException ex)
            {

                ViewBag.Msg = "Erro ao registrar" + ex.Message;
            }

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
