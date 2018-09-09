using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Skeezy.Data;
using Skeezy.Models;
using Microsoft.EntityFrameworkCore;

namespace Skeezy.Controllers
{
    public class MessageSubmission
    {
        public string Text { get; set; }
    }

    public class MessageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MessageController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IList<Message> messages = _context.Messages.Include(m => m.User).ToList();

            return View(messages);
        }

        [HttpPost]
        public IActionResult Submit(string text)
        {
            _context.Messages.Add(new Message
            {
                Text = text,
                UserId = _context.Users.Select(u => u.Id).First()
            });

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}