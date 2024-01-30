namespace PostSimulation
{
    internal class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
