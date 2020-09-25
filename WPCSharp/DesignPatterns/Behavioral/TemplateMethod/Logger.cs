using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class Logger
    {
        public void Log(string message)
        {
            string messageToLog = Serialize(message);
            var diposable = ConnectToService();
            Save(messageToLog);
            CloseServie(diposable);
        }

        private void CloseServie(IDisposable disposable)
        {
            OnCloseService();
            disposable?.Dispose();
        }

        internal abstract void OnCloseService();
        internal abstract IDisposable ConnectToService();
        internal abstract void Save(string messageToLog);
        private string Serialize(string message)
        {
            Console.WriteLine("Serializing message");
            return SerializeMessage(message);
        }

        internal abstract string SerializeMessage(string message);

    }
}
