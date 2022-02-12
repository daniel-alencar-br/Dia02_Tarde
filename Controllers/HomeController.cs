using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dia02_Tarde.Controllers
{
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            return View();
        }

        // public ActionResult RelatorioXML()
        //{
        //  return View();
        //}

        public ActionResult RelatorioXML(int id)
        {
            ViewBag.Cod = id;
            return View();
        }

        public ActionResult Relatorio()
        {
            ViewBag.Cod = "1";
            ViewBag.Nome = "Joao";

            ViewData["Endereco"] = "R. Alguma Coisa";
            ViewData["CEP"] = "05676-090";

            return View();
        }

        public ActionResult ArteAbstrata()
        {
            var Arq = Server.MapPath("~/Imagens/Imagem.jpg");
            return base.File(Arq, "image/jpg");
        }

        public ActionResult Apostila()
        {
            var Arq = Server.MapPath("~/Imagens/Apostila.pdf");
            return base.File(Arq, "application/pdf");
        }

        [HttpGet]
        public ActionResult ValidaAluno(int Id)
        {
            if (Id == 1)
                return Redirect("/Home/Aluno/1");
            else
                return Redirect("/Home/Erro");
        }

        public ActionResult Erro()
        {
            return View();
        }

        [HttpGet]
        public string Aluno(int Id)
        {
            return "Bem vindo " + Convert.ToString(Id);
        }

        
    }
}