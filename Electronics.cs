using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    abstract class Electronics : Product
    {
        public enum ElectronicsType
        {
            Phone,
            ConsumerElectronics,            
            Laptop,
            ComputerParts
        }

        private ElectronicsType m_electronicType;

        public ElectronicsType ElectronicType
        {
            get { return m_electronicType; }
            set
            {
                if(value >= ElectronicsType.Phone && value <= ElectronicsType.ComputerParts)
                    m_electronicType = value;
                else
                {
                    Console.WriteLine("Invalid electronic type");
                }
            }
        }

        public Electronics(string brand,
                           string name,
                           double price,
                           string description,
                           ElectronicsType electronicType)
            : base(brand, name, price, Product.CategoryType.Electronics, description)
        {
            ElectronicType = electronicType;
        }               

    }
}
