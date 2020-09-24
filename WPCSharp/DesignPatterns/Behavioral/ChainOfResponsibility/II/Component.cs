using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public abstract class Component
    {
        public Component Parent { get; set; }

        public void Click()
        {
            Click(false);
        }

        protected virtual void Click(bool handled)
        {
            Parent?.Click(handled);
        }
    }
}
