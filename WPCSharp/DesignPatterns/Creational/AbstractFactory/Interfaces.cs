using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Creational.AbstractFactory
{
    public interface IFactory
    {
        ISedan CreateSedan(string segment);
        ISuv CreateSuv(string segment);
    }
    public interface ICar
    {
        string Name();
    }
    public interface ISedan : ICar
    {

    }
    public interface ISuv : ICar
    {

    }
}
