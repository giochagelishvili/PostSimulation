namespace PostSimulation.Publisher
{
    internal class PostEventArgs : EventArgs
    {
        public Post Post { get; set; }

        public PostEventArgs(Post post)
        {
            Post = post;
        }
    }
}
