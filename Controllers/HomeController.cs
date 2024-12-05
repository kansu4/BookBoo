using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookBoo.Models;
using System.Runtime.CompilerServices;
using BookBoo.Data;
using Microsoft.EntityFrameworkCore;

namespace BookBoo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly BookBooContext bookBooContext;

    public HomeController(ILogger<HomeController> logger, BookBooContext bookBooContext)
    {
        this.bookBooContext =  bookBooContext;
        _logger = logger;
    }

    public IActionResult Login()
    {
        return View();
    }
    
    public IActionResult Dashboard()
    {
        return View();
    }
    
    public IActionResult Index()
    {
        var author = bookBooContext.Authors.ToList();
        foreach(var item in author){
            Console.WriteLine(item.Name);
        }
        return View(author);
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
