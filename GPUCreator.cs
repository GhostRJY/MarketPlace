using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    static class GPUCreator
    {
        public static IProduct CreateGPU(
            string brand,
            string name,
            double price,
            string description,
            string core,
            int frequency,            
            int memorySize,
            int memoryBus,
            int memoryClock)
        {
            return new GPU(brand, name, price, description, core, frequency, memorySize, memoryBus, memoryClock);
        }
    }
}
