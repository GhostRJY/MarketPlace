using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    static class VacCreator
    {
        public static IProduct CreateVac(
            string brand,
            string name,
            double price,
            string description,
            int power)
        {
            return new VacuumCleaner(brand, name, price, description, power);
        }
    }
}
