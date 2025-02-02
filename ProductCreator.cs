using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    abstract class ProductCreator
    {
        abstract public IProduct FactoryMethod();
    }
}
