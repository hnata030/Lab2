using Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class HomeController : Controller
    {
        private static List<DataBaseModel> databaseData = new List<DataBaseModel>();

        public ActionResult Index()
        {
            var model = new DataBaseModel();
            return View(model);
        }
        public ActionResult Add()
        {
            var newDatabase = new DataBaseModel();
            return View(newDatabase);
        }

        [HttpPost]
        public ActionResult Edit(DataBaseModel model)
        {
            // Код сохранения изменений
            return RedirectToAction("Index");
        }
    }
}