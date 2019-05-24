using DBModels;
using ForumSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ForumSystem.Controllers
{
    public class TopicController : Controller
    {
        private readonly ForumDB _context;

        public TopicController(ForumDB context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Topics.Select(t => new TopicViewModel { Id = t.Id, Title = t.Title, Text = t.Text }).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(TopicViewModel topic)
        {
            Topic newTopic = new Topic { Text = topic.Text, Title = topic.Title };
            _context.Topics.Add(newTopic);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
