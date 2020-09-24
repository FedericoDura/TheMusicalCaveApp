using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;
using TheMusicalCaveApp.Services.Interfaces;
using TheMusicalCaveApp.Web.Models;

namespace TheMusicalCaveApp.Controllers
{
    public class HomeController : Controller
    {
        IAlbumService _albumService;
        public HomeController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public ActionResult Index(string search)
        {
            IEnumerable albumsViewModel = new List<Album>();

            if (!string.IsNullOrWhiteSpace(search))
            {
                albumsViewModel = _albumService.GetFilteredAlbums(search).ToViewModel();
            }
            else
            {
                albumsViewModel = _albumService.GetAllAlbums().ToViewModel();
            }
            return View(albumsViewModel);
        }
    }
}