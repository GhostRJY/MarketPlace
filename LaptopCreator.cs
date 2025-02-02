using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    static class LaptopCreator
    {
        public static IProduct CreateLaptop(
            string brand,
            string name,
            double price,
            string description,
            string cpu,
            int ram,
            int hdd,
            string screenResolution,
            string gpu,
            string os)
        {
            return new Laptop(brand, name, price, description, cpu, ram, hdd, screenResolution, gpu, os);
        }
    }
}
