using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Models;

namespace SMS.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
      ViewBag.Message = "Time Now is: ";
      ViewBag.LongTime = DateTime.Now.ToLongDateString(); // make this property of the view bag contain the result of this expression 
      return View();
    }

  public IActionResult About() //anything in here controls data that goes to the about page 
    {
      //get data from a database 
      var about = new AboutViewModel {
         Title = "About Us",
         Message = "We are a consultancy company",
         Formed = new DateTime(2020,1,10)
       };
      return View(about);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
