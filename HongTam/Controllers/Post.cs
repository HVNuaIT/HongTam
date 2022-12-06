using HongTam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HongTam.Controllers
{
    public class Post : Controller
    {
        HongTamSolutionContext db = new HongTamSolutionContext();
        public IActionResult Index()
        {
            var ds = db.Posts.ToList();
            return View(ds);
        }
    }
}
