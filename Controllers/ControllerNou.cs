using Microsoft.AspNetCore.Mvc;

namespace Moldovan_Andrei_Lab1.Controllers
{
    public class ControllerNou : Controller
    {
        public string Index()
        {
            return "Welcome User!";
        }

        public string Hello()
        {
            return "Hello User!";
        }

        public string Parameters(string a, int b)
        {
            a = "Mesaj";
            b = 1;
            return (a + ' ' + b);
        }
    }
}
