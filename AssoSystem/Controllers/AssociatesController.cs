using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AssoSystem.Data;
using AssoSystem.Models;

namespace AssoSystem.Controllers
{
    public class AssociatesController : Controller
    {
        private readonly AssoSystemContext _context;

        public AssociatesController(AssoSystemContext context)
        {
            _context = context;
        }

        // GET: Associates
        public async Task<IActionResult> Index()
        {
              return _context.associates != null ? 
                          View(await _context.associates.ToListAsync()) :
                          Problem("Entity set 'AssoSystemContext.associates'  is null.");
        }

        // GET: Associates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.associates == null)
            {
                return NotFound();
            }

            var associate = await _context.associates
                .FirstOrDefaultAsync(m => m.Id == id);
            if (associate == null)
            {
                return NotFound();
            }

            return View(associate);
        }

        // GET: Associates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Associates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StateNumber,BornDate,PublicPlace,NumberPlace,Neigborhood,AddressComplement,City,State,PostalCode,Gender,MaritalStatus,MaritalStatusId,BirthDate,MothersName,WifeName,IncludeDate,ExitDate,Type,RegisterName,FantasyName,CnpjCpf,Id,CreatedAt,UpdatedAt")] Associate associate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(associate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(associate);
        }

        // GET: Associates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.associates == null)
            {
                return NotFound();
            }

            var associate = await _context.associates.FindAsync(id);
            if (associate == null)
            {
                return NotFound();
            }
            return View(associate);
        }

        // POST: Associates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StateNumber,BornDate,PublicPlace,NumberPlace,Neigborhood,AddressComplement,City,State,PostalCode,Gender,MaritalStatus,MaritalStatusId,BirthDate,MothersName,WifeName,IncludeDate,ExitDate,Type,RegisterName,FantasyName,CnpjCpf,Id,CreatedAt,UpdatedAt")] Associate associate)
        {
            if (id != associate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(associate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssociateExists(associate.Id))
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
            return View(associate);
        }

        // GET: Associates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.associates == null)
            {
                return NotFound();
            }

            var associate = await _context.associates
                .FirstOrDefaultAsync(m => m.Id == id);
            if (associate == null)
            {
                return NotFound();
            }

            return View(associate);
        }

        // POST: Associates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.associates == null)
            {
                return Problem("Entity set 'AssoSystemContext.associates'  is null.");
            }
            var associate = await _context.associates.FindAsync(id);
            if (associate != null)
            {
                _context.associates.Remove(associate);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssociateExists(int id)
        {
          return (_context.associates?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
