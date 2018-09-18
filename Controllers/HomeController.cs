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
            
            if(!Request.Form.Files.Any())
            {
                return RedirectToAction("Resultados");
            }
            var dataService = new DataService();
            var lista = dataService.ProcessarDados(Request.Form.Files[0]);

            // Gerar graficos de torta
            var retornoTorta = dataService.GetLojas(lista);
            var modelo = new ResultadosViewModel();
            modelo.ListaLojas = retornoTorta;

            // Gerar graficos de barra
            var anos = dataService.GetAnos(lista);
            var retornoBar = new ResultadoAnualEntityModel();
            retornoBar.Anos = anos;
            foreach(var ano in anos)
            {
                retornoBar.ValoresAnuais.Add(dataService.GetValoresPorAno(ano, lista));
                retornoBar.VendasAnuais.Add(dataService.GetVendasPorAno(ano, lista));
            }
            modelo.ResultadoAnual = retornoBar;

            return View("Resultados", modelo);
        }
    }
}
