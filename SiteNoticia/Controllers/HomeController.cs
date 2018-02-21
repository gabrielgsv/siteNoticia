using Microsoft.EntityFrameworkCore;
using SiteNoticia.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SiteNoticia.Models;

namespace SiteNoticia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Noticias.ToListAsync());
        }

        public async Task<IActionResult> Noticia(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var noticia = await _context.Noticias
                .SingleOrDefaultAsync(m => m.Id == id);
            if (noticia == null)
            {
                return NotFound();
            }

            return View(noticia);
        } 
    }
}
