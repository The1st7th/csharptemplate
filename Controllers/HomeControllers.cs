using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/form")]
        public ActionResult Form()
        {
          return View();
        }
    
        [Route("/greeting_card")]
        public ActionResult Hello()
        {
          LetterVariable myLetterVariable = new LetterVariable();
          myLetterVariable.SetRecipient(Request.Query["recipient"]);
          myLetterVariable.SetSender(Request.Query["sender"]);
          return View("Hello", myLetterVariable);
        }
        [Route("/journal")]
        public ActionResult Journal()
        {
          return View();
        }
    }
}