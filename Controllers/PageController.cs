using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Data;
using MvcMovie.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class PageController : Controller
    {
        // 
        // GET: /HelloWorld/
 private readonly MvcMovieContext _context;

        public PageController(MvcMovieContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
             var ds = (from c in _context.Movie
                          select c
                         ).ToList();
             return View(ds);
        }

 // POST: Movies/Delete/5
        [HttpPost, ActionName("CreateNew")]
        public IActionResult Createnew(string body)
        {
              return Ok(body);
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        //
        // GET: /HelloWorld/Welcome2/ 
      
    }
}
