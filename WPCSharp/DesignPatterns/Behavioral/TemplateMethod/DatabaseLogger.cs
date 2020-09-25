using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.TemplateMethod
{
    public class DatabaseLogger : Logger
    {
        internal override void OnCloseService()
        {
            Console.WriteLine("Closing DB connection.");
        }

        internal override IDisposable ConnectToService()
        {
            Console.WriteLine("Connecting to Database.");
            return new Service();
        }

        internal override void Save(string messageToLog)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + messageToLog);
        }

        internal override string SerializeMessage(string message)
        {
            return message.ToString();
        }
    }
}
