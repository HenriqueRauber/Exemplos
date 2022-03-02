using Microsoft.AspNetCore.Mvc;

namespace Exemplos.Controllers
{
    public class ExemploController : BaseController
    {
        public IActionResult Index(string nome)
        {
            Dictionary<string, string> files = new()
            {
                {"html", string.Empty },
                {"css", string.Empty },
                {"js", string.Empty }
            };

            foreach (var file in files)
            {
                if (System.IO.File.Exists($"./wwwroot/{file.Key}/{nome}.{file.Key}"))
                {
                    files[file.Key] = System.IO.File.ReadAllText($"./wwwroot/{file.Key}/{nome}.{file.Key}");
                }
            }


            ViewBag.html = files["html"];
            ViewBag.css = files["css"];
            ViewBag.js = files["js"];
            ViewBag.Page = nome;

            ViewBag.Pages = GetPageNames();
            return View();
        }
    }
}
