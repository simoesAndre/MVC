using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade_02.Models;

namespace Atividade_02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Item()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Item(ItemPedido PedidoAtual)
        {
            Pedido.Incluir(PedidoAtual);
            return View("Concluido");
        }

        public IActionResult TotalPedido()
        {
            List<ItemPedido> lista = Pedido.Listar();
            return View(lista);
        }
    }
}
