﻿using Microsoft.AspNetCore.Mvc;

namespace Entra21.CSharp.ClinicaVeterinaria.Aplicacao.Controllers
{
    // Dois pontos mais pra frente é sobre Herença
    public class RacaController : Controller
    {
        /// <summary>
        /// Endpoint que permite lista todas as raças
        /// </summary>
        /// <returns>Retorna a página html com as raças</returns>
        [Route("/raca")]
        [HttpGet]

        public IActionResult ObterTodos()
        {
            return View("Index");
        }

        [Route("/raca/cadastrar")]
        [HttpGet]

        public IActionResult Cadastrar()
        {
            return View();
        }

        [Route("/raca/registrar")]
        [HttpGet]

        public IActionResult Registrar (
            [FromQuery()] string nome,
            [FromQuery()] string especie)
        {
            return RedirectToAction("Index");
        }
    }
}