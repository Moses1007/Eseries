using Eseries.Models.Domain;
using Eseries.Repository.Abstract;
using Eseries.Repository.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace Eseries.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenre _genreService;
        public GenreController(IGenre genre)
        {
            _genreService = genre;
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Genre genre)
        {

            if (!ModelState.IsValid)
                return View(genre);
            var result = _genreService.Add(genre);
            if (result)
            {
                TempData["msg"] = "Added Successfully";
                return RedirectToAction(nameof(Add));
            }
            else
            {
                TempData["msg"] = "Error on server side";
                return View(genre);
            }

        }

        public IActionResult Edit(int id)
        {
            var data = _genreService.GetById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Update(Genre model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var result = _genreService.Update(model);
            if (result)
            {
                TempData["msg"] = "Added Successfully";
                return RedirectToAction(nameof(GenreList));
            }
            else
            {
                TempData["msg"] = "Error on server side";
                return View(model);
            }
        }
        public IActionResult GenreList()
        {
            var data = this._genreService.GetList().ToList();
            return View(data);
        }

        public IActionResult Delete(int id)
        {
            var result = _genreService.Delete(id);
            return RedirectToAction(nameof(GenreList));
        }
    }
}
