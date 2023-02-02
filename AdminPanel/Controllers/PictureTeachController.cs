using AdminPanel.Models;
using AdminPanel.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class PictureTeachController : Controller
    {
        PicturesService PicturesService;
        public PictureTeachController(ApplicationContext context, IWebHostEnvironment env)
        {
            PicturesService = new PicturesService(context);
        }
        public IActionResult PicturesEdit(int teachId)
        {
            var listPictures = PicturesService.GetAll(teachId);
            return View(listPictures);
        }
        public IActionResult DeletePicture([FromForm] Models.FileTeach pictures)
        {
            //Получить айди фото для удаления
            PicturesService.Delete(pictures);
            return RedirectToAction("IndexTeacher", "Teacher");

        }
    }
}
