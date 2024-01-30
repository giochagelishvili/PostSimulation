using PostSimulation.Publisher;

namespace PostSimulation.Subscriber
{
    internal class NotificationService
    {
        public void OnPostPublished(object? sender, PostEventArgs args)
        {
            Console.WriteLine($"Notification: \"{args.Post.Title}\" has been published.");
        }
    }
}
