using AdminPanel.Models;
using AdminPanel.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace AdminPanel.Controllers
{
    public class ManagerController : Controller
    {
        ManagerService ManagerService;
        IWebHostEnvironment _environment;
        PicturesService PicturesService;

        public ManagerController(ApplicationContext context, IWebHostEnvironment env)
        {
            _environment = env;
            ManagerService= new ManagerService(context);    
            PicturesService = new PicturesService(context);
        }
        public IActionResult IndexManager()
        {
            var listManager = ManagerService.GetAll();
            return View(listManager);
        }
        public IActionResult MD(int ManagerId)
        {
            var listManager = ManagerService.GetDetails(ManagerId);
            return View(listManager);
        }
        [HttpPost]
        public IActionResult EditManager(int ManagerId)
        {
            var oneManager = ManagerService.GetDetails(ManagerId);
            return View(oneManager);
        }
        public IActionResult DeleteManager([FromForm] Managers managers)
        {
            ManagerService.DeleteManagers(managers);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult EditManager([FromForm] Managers managers)
        {
            ManagerService.Edit(managers);
            return RedirectToAction("Index");
        }
    }
}
