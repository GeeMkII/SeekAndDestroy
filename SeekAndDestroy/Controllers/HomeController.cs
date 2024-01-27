using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SeekAndDestroy.Models;

namespace SeekAndDestroy.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        var model = new About()
        {
            Title = "Northwind app",
            Description = "Some desc.",
            Tags = new List<string>()
            {
                "aaa",
                "bbb"
            }
        };
        return View(model);
    }

    public IActionResult Privacy()
    {
        var model = new List<Product>()
        {
            new Product()
                {
                    ProductId = "1",
                    ProductName = "Test1"
                },
            new Product()
                {
                    ProductId = "2",
                    ProductName = "Test2"
                },
            
        };
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
