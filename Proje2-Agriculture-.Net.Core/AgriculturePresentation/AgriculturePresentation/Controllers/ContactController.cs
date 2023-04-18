using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
       
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.TGetListAll();
            return View(values);
        }

        public IActionResult DeleteMessage(int id)
        {
            var values = _contactService.TGetById(id);
            _contactService.TDelete(values);
            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            var value = _contactService.TGetById(id);
            return View(value);
        }
        
    }
}
