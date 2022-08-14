using comic_book_gallery.Data;
using comic_book_gallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comic_book_gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;
        
        //Constructor
        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);
        }

        public ActionResult Detail(int id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);





            return View(comicBook);   
        }
    }
}
