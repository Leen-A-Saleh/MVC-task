using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
namespace WebApplication1.Controllers
{
    public class employeeController : Controller
    {
        ApplicationDbContext contetx = new ApplicationDbContext();
        public IActionResult Index()
        {
            var employee = contetx.employees.ToList();
            return View("Index",employee);
        }
    }
}
