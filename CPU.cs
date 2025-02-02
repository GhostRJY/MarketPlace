using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    internal class CPU : Electronics
    {
        private string m_socket;
        private int m_cores;
        private int m_cache;
        private int m_frequency;

        public string Socket
        {
            get { return m_socket; }
            set
            {
                if(value.Length == 0)
                    value = "Unknown";
                m_socket = value;
            }
        }

        public int Cores
        {
            get { return m_cores; }
            set
            {
                if(value > 0)
                    m_cores = value;
                else
                {
                    Console.WriteLine("Invalid cores");
                }
            }
        }

        public int Cache
        {
            get { return m_cache; }
            set
            {
                if(value > 3)
                    m_cache = value;
                else
                {
                    Console.WriteLine("Invalid cash");
                }
            }
        }

        public int Frequency
        {
            get { return m_frequency; }
            set
            {
                if(value > 0)
                    m_frequency = value;
                else
                {
                    Console.WriteLine("Invalid frequency");
                }
            }
        }

        public CPU(string brand,
                    string name,
                    double price,
                    string description,
                    string socket,
                    int cores,
                    int cache,
                    int frequency)
            : base(brand, name, price, description, Electronics.ElectronicsType.ComputerParts)
        {
            this.Socket = socket;
            this.Cores = cores;
            this.Cache = cache;
            this.Frequency = frequency;
        }

        public override void ShowProduct()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Товар: Компьютерные компоненты(Процессор)");
            Console.WriteLine($"Бренд: {Brand}");
            Console.WriteLine($"Модель: {Name}");
            Console.WriteLine($"Сокет: {Socket}");
            Console.WriteLine($"Количество ядер: {Cores}");
            Console.WriteLine($"Кэш: {Cache}");
            Console.WriteLine($"Частота: {Frequency}");
            Console.WriteLine($"Цена: {Price}\n\n");
            
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine($"Описание: {Description}");
            Console.ResetColor();
        }
    }
}
