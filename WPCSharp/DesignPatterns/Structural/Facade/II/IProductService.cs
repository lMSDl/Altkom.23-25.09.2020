﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Structural.Facade.II
{
    public interface IProductService
    {
        float GetPrice(int cartId);
    }
}
