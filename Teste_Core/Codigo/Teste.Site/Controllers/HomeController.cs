using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Teste.Business.NumeroEstranho;
using Microsoft.AspNetCore.Mvc;
using Teste_Teste.Models;
using Newtonsoft.Json;
using Teste.Business.CEP;
using Altran.Business.CEP;

namespace Teste_Teste.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            NumeroModel model = new NumeroModel();
            return View("Index", model);
        }

        [HttpPost]
        public IActionResult Index(NumeroModel model)
        {
            ///Chamada da camada que faz o cálculo do número estranho
            Calculo calcNumEstranho = new Calculo();
            model.Retorno = calcNumEstranho.CalculoNumEstranho(model.Numero);

            return View("Index", model);
        }

        public IActionResult CEP()
        {
            CEPModel model = new CEPModel();
            return View("CEP", model);
        }

        [HttpPost]
        public IActionResult CEP(CEPModel model)
        {
            if (model.CEP != "")
            {
                ///Conexão com api que retorna as informações de um CEP
                var requisicaoWeb = WebRequest.CreateHttp("https://viacep.com.br/ws/" + model.CEP + @"/json/");

                requisicaoWeb.Method = "GET";
                requisicaoWeb.ContentType = "text/html";
                requisicaoWeb.Headers.Add("cache-control", "no-cache");
                try
                {
                    var response = (HttpWebResponse)requisicaoWeb.GetResponse();
                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    response.Close();

                    model.Retorno = JsonConvert.DeserializeObject<RetornoCep>(responseString);

                    ///Chamada do método que insere as informações da busca em uma tabela
                    GerenciamentoCep gerCep = new GerenciamentoCep();
                    gerCep.GravaCep(model.Retorno);
                }
                catch (Exception)
                {

                }
            }
            return View("CEP", model);
        }
    }
}
