using Microsoft.AspNetCore.Mvc;

namespace WebGentle.BookStore.Controllers
{
    public class HomeController:Controller
    {

        public string Index()
        {
            return "Web Gentle"; 
        }
    }
}
