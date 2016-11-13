using PushSharp.Core;

namespace PushSharp.Firebase
{
    public class FcmNotificationException : NotificationException
    {
        public FcmNotificationException(FcmNotification notification, string msg) : base(msg, notification)
        {
            Notification = notification;
        }

        public FcmNotificationException(FcmNotification notification, string msg, string description) : base(msg, notification)
        {
            Notification = notification;
            Description = description;
        }

        public new FcmNotification Notification { get; private set; }
        public string Description { get; private set; }
    }
}
