using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sia.Models;
using sia.Service;

namespace sia.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Resultados(ResultadosViewModel lista)
        {
            if(lista == null && lista.ListaLojas.Any()){
                return View();
            }
            return View(lista);
        }

        [HttpPost]
        public IActionResult Carregar(){
            
            if(!Request.Form.Files.Any()){
                //return Resultados(new List<DataEntityModel>());    
                return RedirectToAction("Resultados");
            }
            var dataService = new DataService();

            var lista = dataService.ProcessarDados(Request.Form.Files[0]);
            var retorno = dataService.GetLojas(lista);
            var modelo = new ResultadosViewModel();
            modelo.ListaLojas = retorno;

            return View("Resultados", modelo);
        }
    }
}
