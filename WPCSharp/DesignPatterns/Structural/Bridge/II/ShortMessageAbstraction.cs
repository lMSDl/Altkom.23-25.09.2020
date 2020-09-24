using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Bridge.II
{
    public class ShortMessageAbstraction : MessageAbstraction
    {
        public ShortMessageAbstraction(IMessageSenderImplementation messageSender) : base(messageSender)
        {
        }

        public override void Send(string message)
        {
            if (message.Length > SmsGate.MaxLength)
                Console.WriteLine("Wiadomość za długa");
            else
                base.Send(message);
        }
    }
}
