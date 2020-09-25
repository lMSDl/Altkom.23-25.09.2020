using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.TemplateMethod
{
    public class FileLogger : Logger
    {
        internal override IDisposable ConnectToService()
        {
            return new Service();
        }

        internal override void OnCloseService()
        {
            Console.WriteLine("Close File.");
        }
        
        internal override void Save(string messageToLog)
        {
            Console.WriteLine("Appending Log message to file : " + messageToLog);
        }

        internal override string SerializeMessage(string message)
        {
            return message.ToString();
        }
    }
}
