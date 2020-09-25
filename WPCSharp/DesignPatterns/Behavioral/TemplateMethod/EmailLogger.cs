using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.TemplateMethod
{
    public class EmailLogger : Logger
    {
        internal override IDisposable ConnectToService()
        {
            return null;
        }

        internal override void OnCloseService()
        {
        }


        internal override void Save(string messageToLog)
        {
            Console.WriteLine("Sending Email with Log Message : " + messageToLog);
        }

        internal override string SerializeMessage(string message)
        {
            return message.ToString();
        }
    }
}
