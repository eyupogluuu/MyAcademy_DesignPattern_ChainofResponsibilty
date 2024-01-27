using Microsoft.AspNetCore.Mvc;
using MyAcademy_DesignPattern_ChainofResponsibilty.ChainOfResponsibility;
using MyAcademy_DesignPattern_ChainofResponsibilty.Models;

namespace MyAcademy_DesignPattern_ChainofResponsibilty.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer= new Treasurer();
            Employee managerAsisstant= new ManagerAsisstant();
            Employee manager = new Manager();
            Employee areadirector = new AreaDirector();

            treasurer.SetNextApprover(managerAsisstant);
            managerAsisstant.SetNextApprover(manager);
            manager.SetNextApprover(areadirector);

            treasurer.ProcessRequest(model);
            return View();
        }
    }
}
