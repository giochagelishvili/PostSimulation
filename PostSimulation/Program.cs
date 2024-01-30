using PostSimulation.Publisher;
using PostSimulation.Subscriber;

namespace PostSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post = new("This is post title", "This is post description.");

            PostPublisher postPublisher = new();

            MailService mailService = new();
            NotificationService notificationService = new();

            postPublisher.PostPublished += mailService.OnPostPublished;
            postPublisher.PostPublished += notificationService.OnPostPublished;

            postPublisher.Publish(post);            
        }
    }
}
