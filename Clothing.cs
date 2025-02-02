using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    internal class Clothing : Product
    {
        private int m_size;

        public int Size
        {
            get { return m_size; }
            set
            {
                if(value > 2)
                    m_size = value;
                else
                {
                    Console.WriteLine("Size must be greater than 20");
                }
            }
        }

        public Clothing(string brand,
                        string name,
                        double price,
                        string description,
                        int size)
            : base(brand, name, price, Product.CategoryType.Clothing, description)
        {
            Size = size;
        }

        public override void ShowProduct()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Товар: Одежда");
            Console.WriteLine($"Бренд: {Brand}");
            Console.WriteLine($"Размер: {Size}");
            Console.WriteLine($"Цена: {Price}\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Описание: {Description}");
            Console.ResetColor();
        }

    }
}
