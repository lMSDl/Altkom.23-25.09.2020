using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Decorator
{
    public class Client
    {

        public static void Execute()
        {
            var test = Console.ReadLine();

            INotification notification = new Notification();
            Console.WriteLine("SMS?");
            if (string.Compare(Console.ReadLine(), "Y", true) == 0)
                notification = new SmsNotification(notification);
            Console.WriteLine("Email?");
            if (string.Compare(Console.ReadLine(), "Y", true) == 0)
                notification = new EmailNotification(notification);

            notification.Send(test);
        }
    }
}
