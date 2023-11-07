using System.Collections.ObjectModel;

namespace CompositeValidation.Notifications
{
    public class NotificationContext
    {
        private List<Notification> _notifications { get; set; }
        public ReadOnlyCollection<Notification> Notifications => _notifications.AsReadOnly();
        public bool HasNotifications => _notifications.Any();

        public NotificationContext()
        {
            _notifications = new List<Notification>();
        }

        public void AddNotification(string key, string message, bool isValid)
        {
            _notifications.Add(new Notification(key, message, isValid));
        }

        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            _notifications.AddRange(notifications);
        }

        public Notification GetCombinedNotification()
        {
            bool isValid = _notifications.Any(n => !n.IsValid);
            string key = _notifications.FirstOrDefault(new Notification()).Key;
            List<string> messages = _notifications.SelectMany(n => n.Messages).ToList();
            

            return new Notification
            {
                IsValid = isValid,
                Key = key,
                Messages = messages
            };
        }

    }
}
