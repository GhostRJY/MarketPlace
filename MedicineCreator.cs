using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    static class MedicineCreator
    {
        public static IProduct CreateMedicine(
            string brand,
            string name,
            double price,
            string description,
            string medicineType)
        {
            return new Medicine(brand, name, price, description, medicineType);
        }
    }
}
