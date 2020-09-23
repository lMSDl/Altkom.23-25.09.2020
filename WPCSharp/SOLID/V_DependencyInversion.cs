using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.SOLID.D
{
    interface IMessenger
    {
        void Send();
    }

    class SMS : IMessenger
    {
        string Number { get; set; }
        string Content { get; set; }

        public void Send()
        {
            SendSMS();
        }

        public void SendSMS()
        {
            Console.WriteLine("Sending SMS...");
        }
    }
    class MMS : IMessenger
    {
        string Number { get; set; }
        byte[] Content { get; set; }

        public void Send()
        {
            SendMMS();
        }

        public void SendMMS()
        {
            Console.WriteLine("Sending MMS...");
        }
    }
    class Email : IMessenger
    {
        string Address { get; set; }
        string Subject { get; set; }
        string Content { get; set; }

        public void Send()
        {
            SendEmail();
        }

        public void SendEmail()
        {
            Console.WriteLine("Sending email...");
        }
    }

    class Messenger {
        
        public IEnumerable<IMessenger> Messeges { get; set; }

        public void SendMessage()
        {
            Messeges.ToList().ForEach(x => x.Send());
        }
}
}
