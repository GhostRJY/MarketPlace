using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    static class CPUCreator
    {
        public static IProduct CreateCPU(
            string brand,
            string name,
            double price,
            string description,
            string socket,
            int cores,
            int cache,
            int frequency)
        {
            return new CPU(brand, name, price, description, socket, cores, cache, frequency);
        }
    }
}
