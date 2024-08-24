using System.Linq;

namespace NotificationSystemEx.Observers.Interfaces
{
    // Subject
    public interface INotificationService
    {
        void Add(User user);
        void Remove(User user);
        void Notify(string message);
    }
    // ConcreteSubject
    public class NotificationService : INotificationService
    {
        private List<User> _subscribers = new List<User>();
        public void Add(User user)
        {
            _subscribers.Add(user);
        }
        public void Remove(User user)
        {
            if (_subscribers.Contains(user))
            {
                _subscribers.Remove(user);
            }
        }
        public void Notify(string message)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Notify(message);
            }
        }
    }

    public interface IObserver
    {
        void Notify(string message);
    }
    public class User : IObserver
    {
        public string Message { get; private set; }

        public void Notify(string message)
        {
            Message = message;
            Console.WriteLine($"Notification received: {message}");
        }

    }
}
