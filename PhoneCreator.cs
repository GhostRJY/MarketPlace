using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    static class PhoneCreator
    {
        public static IProduct CreatePhone(
            string brand,
            string name,
            double price,
            string description,
            int ram,
            string cpu,
            int frequency,
            string os)
        {
            return new Phone(brand, name, price, description, ram, cpu, frequency, os);
        }
    }
}
