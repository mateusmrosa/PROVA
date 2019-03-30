using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProvaPrimeiroBim.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Logar([FromBody] Dictionary<string, string> dados)
        {
            string msg = "";
            bool ok = f.Logar(out );

            Models.Funcionario f = new Models.Funcionario();
            f.Usuario = dados["usuario"];
            f.Senha = dados["senha"];


            var operacao = new
            {
                operacao = msg,
                msg = "Entrou"
            };

            //if(f.Usuario.Length > 5)
            //{

            //}

            return Json(operacao);
        }
    }
}