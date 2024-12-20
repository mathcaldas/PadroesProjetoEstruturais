using System;
using NotificationSystem.Decorators;
using NotificationSystem.Interfaces;
using NotificationSystem.Notifications;

class Program
{
    static void Main(string[] args)
    {
        INotification notification = new BaseNotification();
        
        INotification emailNotification = new EmailDecorator(notification);
        emailNotification.Send("Email");

        INotification smsNotification = new SMSDecorator(notification);
        smsNotification.Send("SMS");

        INotification pushNotification = new PushDecorator(notification);
        pushNotification.Send("Notification");
    }
}