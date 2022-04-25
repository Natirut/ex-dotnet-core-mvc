using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Data;
using MvcMovie.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Controllers
{
    public class DumbleController : Controller
    {
        // 
        // GET: /HelloWorld/
        private readonly MvcMovieContext _context;

        public DumbleController(MvcMovieContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var ds = (from c in _context.Dumble
                      select c
                        ).ToList();
            return View(ds);
        }


        public IActionResult Insert()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Insert([Bind("id,pd_name,pd_price,pd_supplier,pd_date,pd_color")] Dumble body)
        {
            if (ModelState.IsValid)
            {
                _context.Add(body);
                await _context.SaveChangesAsync();
                return Json("ok");
            }
            return View(body);
        }

         public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var record = await _context.Dumble.FindAsync(id);
            if (record == null)
            {
                return NotFound();
            }
            return View(record);
        }

             [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("id,pd_name,pd_price,pd_supplier,pd_date,pd_color")] Dumble body)
        {
            if (id != body.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                    _context.Dumble.Update(body);
                    await _context.SaveChangesAsync();
              
                return RedirectToAction(nameof(Index));
            }
            return View(body);
        }

           public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var record = await _context.Dumble
                .FirstOrDefaultAsync(m => m.id == id);
            if (record == null)
            {
                return NotFound();
            }

            return View(record);
        }

          [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var record = await _context.Dumble.FindAsync(id);
            _context.Dumble.Remove(record);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}
