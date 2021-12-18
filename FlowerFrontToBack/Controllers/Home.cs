using System;
using Microsoft.AspNetCore.Mvc;

namespace FlowerFrontToBack.Controllers
{
    public class Home:Controller
    {
       public ActionResult Index()
        {
            return View();
        }
    }
}
