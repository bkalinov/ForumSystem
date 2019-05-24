using DBModels;
using System.Collections.Generic;

namespace ForumSystem.Models
{
    public class TopicViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
