using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Decorator
{
    public class SmsNotification : BaseDecorator
    {
        public SmsNotification(INotification notification) : base(notification)
        {
        }

        public override void SendExtra(string message)
        {
            Console.WriteLine("SMS: " + message);
        }
    }
}
