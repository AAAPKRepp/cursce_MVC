using System.Reflection.Metadata.Ecma335;
using cursce.Data;
using cursce.Models;
using Microsoft.AspNetCore.Mvc;

namespace cursce.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly List<string> _deathCauses = new List<string>()
        {
          "Попал под машину", "Потонул в луже", "Упал с лестницы"
        };
        public CategoryController(ApplicationDbContext db)
        {
        _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                if (obj.CauseOfDeath == "random")
                {
                    Random rnd = new Random();
                    obj.CauseOfDeath = _deathCauses[rnd.Next(_deathCauses.Count)];
                }

                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Categories.Find(id);
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);
            //Category? categoryFromDb2 = _db.Categories.Where(u => u.Id == id).FirstOrDefault();

            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category? obj = _db.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Он ожил;)";
            return RedirectToAction("Index");
        }
    }
}
