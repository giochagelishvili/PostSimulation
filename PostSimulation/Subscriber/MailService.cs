using PostSimulation.Publisher;

namespace PostSimulation.Subscriber
{
    internal class MailService
    {
        public void OnPostPublished(object? sender, PostEventArgs args) => Console.WriteLine($"Mail: \"{args.Post.Title}\" has been published.");
    }
}
