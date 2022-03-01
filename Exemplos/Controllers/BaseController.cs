using Microsoft.AspNetCore.Mvc;

namespace Exemplos.Controllers
{
    public class BaseController : Controller
    {

        protected static List<String> GetPageNames()
        {
            List<String> filesHtml = new List<String>();
            foreach (var file in Directory.GetFiles("./wwwroot/html"))
            {
                filesHtml.Add(Path.GetFileNameWithoutExtension(file));
            }
            return filesHtml;
        }
    }
}
