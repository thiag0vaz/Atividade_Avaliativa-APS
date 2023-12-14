#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Francisco_Thiago.Models;

namespace Francisco_Thiago.Controllers
{
    public class PagamentoComCartoesController : Controller
    {
        private readonly MyDbContext _context;

        public PagamentoComCartoesController(MyDbContext context)
        {
            _context = context;
        }

        // GET: PagamentoComCartoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.PagamentoComCartaos.ToListAsync());
        }

        // GET: PagamentoComCartoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagamentoComCartao = await _context.PagamentoComCartaos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pagamentoComCartao == null)
            {
                return NotFound();
            }

            return View(pagamentoComCartao);
        }

        // GET: PagamentoComCartoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PagamentoComCartoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NumeroDoCartao,Bandeira,Id,NomeDoCobrado,InformacoesAdicionais")] PagamentoComCartao pagamentoComCartao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pagamentoComCartao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pagamentoComCartao);
        }

        // GET: PagamentoComCartoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagamentoComCartao = await _context.PagamentoComCartaos.FindAsync(id);
            if (pagamentoComCartao == null)
            {
                return NotFound();
            }
            return View(pagamentoComCartao);
        }

        // POST: PagamentoComCartoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NumeroDoCartao,Bandeira,Id,NomeDoCobrado,InformacoesAdicionais")] PagamentoComCartao pagamentoComCartao)
        {
            if (id != pagamentoComCartao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pagamentoComCartao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PagamentoComCartaoExists(pagamentoComCartao.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pagamentoComCartao);
        }

        // GET: PagamentoComCartoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pagamentoComCartao = await _context.PagamentoComCartaos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pagamentoComCartao == null)
            {
                return NotFound();
            }

            return View(pagamentoComCartao);
        }

        // POST: PagamentoComCartoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pagamentoComCartao = await _context.PagamentoComCartaos.FindAsync(id);
            _context.PagamentoComCartaos.Remove(pagamentoComCartao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PagamentoComCartaoExists(int id)
        {
            return _context.PagamentoComCartaos.Any(e => e.Id == id);
        }
    }
}
