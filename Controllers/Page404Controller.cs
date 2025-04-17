using Microsoft.AspNetCore.Mvc;

namespace MyWebSite.Controllers;

public class Page404Controller : Controller
{
    public IActionResult index()
    {
        return View();
    }
}