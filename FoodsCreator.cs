using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    static class FoodsCreator
    {
        public static IProduct CreateFood(string brand,
                     string name,
                     double price,
                     string description,
                     int calories,
                     DateTime expirationDate)
        {
         return new Foods(brand, name, price, description, calories, expirationDate);
        }
    }
}
