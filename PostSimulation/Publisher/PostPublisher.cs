namespace PostSimulation.Publisher
{
    internal class PostPublisher
    {
        public event EventHandler<PostEventArgs>? PostPublished;

        public void Publish(Post post)
        {
            Console.WriteLine("Publishing post...");
            Thread.Sleep(3000);

            OnPostPublished(post);
        }

        private void OnPostPublished(Post post)
        {
            if (PostPublished != null)
                PostPublished(this, new PostEventArgs(post));
        }
    }
}
