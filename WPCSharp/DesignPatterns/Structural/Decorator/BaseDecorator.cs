using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Decorator
{
    public abstract class BaseDecorator : INotification
    {
        private INotification Notification { get; }
        protected BaseDecorator(INotification notification)
        {
            Notification = notification;
        }

        public void Send(string message)
        {
            Notification.Send(message);
            SendExtra(message);
        }

        public abstract void SendExtra(string message);
    }
}
