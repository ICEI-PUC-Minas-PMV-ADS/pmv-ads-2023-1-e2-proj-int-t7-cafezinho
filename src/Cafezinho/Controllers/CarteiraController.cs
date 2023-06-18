using System.Security.Claims;
using Cafezinho.Models;
using Cafezinho.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cafezinho.Controllers
{
    public class Carteira : Controller
    {
        private readonly ApplicationDbContext _context;

        public Carteira(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            string ClienteCPF = User.Claims
                .Where((claim) => claim.Type == ClaimTypes.Sid)
                .First()
                .Value;
            List<Registro> todosregistros = await _context.Registros.ToListAsync();
            List<Registro> registros = todosregistros
                .Where((registro) => registro.ClienteId == ClienteCPF)
                .ToList();
            List<Venda> vendas = _context.Vendas
                .ToList()
                .Where(
                    (venda) => registros.Any((registro) => registro.RegistroId == venda.RegistroId)
                )
                .ToList();

            return View(new CarteiraListViewModel() { Registros = registros, Vendas = vendas });
        }

        public async Task<ActionResult> Vender(int? id)
        {
            if (id == null || _context.Registros == null)
            {
                return NotFound();
            }

            var registro = await _context.Registros.FindAsync(id);
            string ClienteCPF = User.Claims
                .Where((claim) => claim.Type == ClaimTypes.Sid)
                .First()
                .Value;

            if (registro == null || registro.ClienteId != ClienteCPF)
            {
                return NotFound();
            }

            int quantidadeMax = VerificarQuantidadeMax(registro);

            if (quantidadeMax <= 0)
            {
                return RedirectToAction("Index");
            }

            var viewModel = new CreateVendaViewModel()
            {
                Registro = registro,
                RegistroId = (int)id,
                QuantidadeMax = quantidadeMax,
                Preco = 0,
                Quantidade = 0,
                DtTransacao = DateTime.Today,
            };

            return View(viewModel);
        }

        int VerificarQuantidadeMax(Registro registro)
        {
            List<Venda> vendas = _context.Vendas
                .ToList()
                .Where((venda) => registro.RegistroId == venda.RegistroId)
                .ToList();

            int counter = 0;

            foreach (var venda in vendas)
            {
                counter += venda.Quantidade;
            }
            return registro.Quantidade - counter;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Vender(int id, IFormCollection form)
        {
            var preco = decimal.Parse(
                form.Where(pair => pair.Key == "Preco").Single().Value.ToString()
            );
            var quantidade = int.Parse(
                form.Where(pair => pair.Key == "Quantidade").Single().Value.ToString()
            );
            var data = DateTime.Parse(
                form.Where(pair => pair.Key == "DtTransacao").Single().Value.ToString()
            );

            if (ModelState.IsValid)
            {
                Console.WriteLine("gay");
                var newVenda = new Venda(preco, quantidade, data, id);

                await _context.Vendas.AddAsync(newVenda);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        public IActionResult DeleteVenda(int? id)
        {
            if (id == null || _context.Vendas == null)
            {
                return NotFound();
            }

            var venda = _context.Vendas.Find(id);
            if (venda == null)
            {
                return NotFound();
            }

            return View(venda);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteVenda(int id)
        {
            var venda = _context.Vendas.Find(id);

            _context.Vendas.Remove(venda);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
