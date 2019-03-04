using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        private readonly StoreContext _context;
        public StoreController(StoreContext context)
        {
            _context = context;
        }

        public IActionResult ListGenres()
        {
            var genres = _context.Genres.OrderBy(g => g.Name);
            return View(genres);
        }

        public IActionResult ListAlbums(int id)
        {
            var albums = _context.Albums.Where(a => a.GenreID == id).OrderBy(a=>a.Title).ToList();
            var genre = _context.Genres.FirstOrDefault(g => g.GenreID == id);
            ViewData["Genre"] = genre.Name.ToString();
            return View(albums); 
        }

        public IActionResult Details(int id)
        {
            var album = _context.Albums
                .Include(a => a.Artist)
                .Include(a => a.Genre).FirstOrDefault(a => a.AlbumID == id);
            return View(album);
        }

    }
}