using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.AbstractFactory
{
    public class HondaFactory : IFactory
    {
        public ISedan CreateSedan(string segment)
        {
            switch(segment)
            {
                case "compact":
                    return new HondaCompactSedan();
                case "full":
                    return new HondaFullSedan();
                default:
                    return null;
            }
        }

        public ISuv CreateSuv(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new HondaCompactSuv();
                case "full":
                    return new HondaFullSuv();
                default:
                    return null;
            }
        }
    }

    public class ToyotaFactory : IFactory
    {
        public ISedan CreateSedan(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new ToyotaCompactSedan();
                case "full":
                    return new ToyotaFullSedan();
                default:
                    return null;
            }
        }

        public ISuv CreateSuv(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new ToyotaCompactSuv();
                case "full":
                    return new ToyotaFullSuv();
                default:
                    return null;
            }
        }
    }
}
