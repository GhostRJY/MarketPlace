using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    static class ClothingCreator
    {
        public static IProduct CreateClothing(
            string brand,
            string name,
            double price,
            string description,
            int size
            )
        {
            return new Clothing(brand, name, price, description, size);
        }
    }
}
