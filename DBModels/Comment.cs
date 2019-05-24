namespace DBModels
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
