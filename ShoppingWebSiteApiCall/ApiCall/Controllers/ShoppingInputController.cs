using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ApiCall.BusinessLogic;
using ApiCall.InputData;

namespace ApiCall.Controllers
{
    public class ShoppingInputController : Controller
    {
        private readonly ApplicationDBContext _context;

        public ShoppingInputController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Shopping
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShoppingInput.ToListAsync());
        }

        // GET: Shopping/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoppingInput = await _context.ShoppingInput
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shoppingInput == null)
            {
                return NotFound();
            }

            return View(shoppingInput);
        }

        // GET: Shopping/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Shopping/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductImage,ProductName,ProductPriceM,ProductPriceF,BrandName,CompanyImage,Categpories,StarRatings")] ShoppingInput shoppingInput)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shoppingInput);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shoppingInput);
        }

        // GET: Shopping/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoppingInput = await _context.ShoppingInput.FindAsync(id);
            if (shoppingInput == null)
            {
                return NotFound();
            }
            return View(shoppingInput);
        }

        // POST: Shopping/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductImage,ProductName,ProductPriceM,ProductPriceF,BrandName,CompanyImage,Categpories,StarRatings")] ShoppingInput shoppingInput)
        {
            if (id != shoppingInput.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shoppingInput);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShoppingInputExists(shoppingInput.Id))
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
            return View(shoppingInput);
        }

        // GET: Shopping/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoppingInput = await _context.ShoppingInput
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shoppingInput == null)
            {
                return NotFound();
            }

            return View(shoppingInput);
        }

        // POST: Shopping/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shoppingInput = await _context.ShoppingInput.FindAsync(id);
            if (shoppingInput != null)
            {
                _context.ShoppingInput.Remove(shoppingInput);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShoppingInputExists(int id)
        {
            return _context.ShoppingInput.Any(e => e.Id == id);
        }
    }
}
