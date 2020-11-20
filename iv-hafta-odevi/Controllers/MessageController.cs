using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iv_hafta_odevi.Models;
using Microsoft.AspNetCore.Mvc;

namespace iv_hafta_odevi.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View(listOfMessage);
        }
        [HttpGet]
        public IActionResult Message()
        {
            Message message = new Message();
            return View(message);
        }
        [HttpPost]
        public IActionResult Message(Message parMessage)
        {
            if (ModelState.IsValid)
            {
                listOfMessage.Add(parMessage);
                return View("Index", listOfMessage);
            }
            return View(parMessage);
        }
        public List<Message> listOfMessage = new List<Message>();
        public MessageController()
        {
            listOfMessage.Add(new Message { MessageId = 1, message = "test message" });
        }
    }
}
