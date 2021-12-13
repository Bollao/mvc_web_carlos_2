using EJOGOS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EJOGOS.Controllers
{
    public class EquipeController : Controller
    {
        //IActionResult representa retorno de status HTTP.

        Equipe equipeModel = new Equipe();


        //500 erro

        //200 OK
        public IActionResult Index()
        {
            //VIEW = responsavel pela exibição do front-end.

            //bag = armazenar as informações back-end
            //para serem acessadas no front-end

            ViewBag.Equipes = equipeModel.ReadAll();

            return View();
        }



        //public IActionResult Cadastrar(IFormCollection form)
        //{



        //}
    }
}
