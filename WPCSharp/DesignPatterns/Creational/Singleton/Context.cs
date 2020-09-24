using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.Singleton
{
    public class Context
    {
        private Dictionary<string, string> _settings = new Dictionary<string, string>();

        private Context()
        {
            Console.WriteLine("Inicjalizacja singletona");

            _settings.Add("1", "A");
            _settings.Add("2", "B");
            _settings.Add("3", "C");
        }

        public static Context Instance { get; } = new Context();

        //private static Context _instance;
        //private static object _locker = new object();
        //public static Context GetInstance()
        //{
        //    lock(_locker)
        //    {
        //        if (_instance == null)
        //            _instance = new Context();
        //        return _instance;
        //    }
        //}


        public string GetSettings(string key)
        {
            return _settings[key];
        }
        public void SetSettings(string key, string value)
        {
            _settings[key] = value;
        }
    }
}
