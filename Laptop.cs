using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    internal class Laptop : Electronics
    {
        private string m_cpu;
        private int m_ram;
        private int m_hdd;
        private string m_screenResolution;
        private string m_gpu;
        private string m_os;

        public string CPU
        {
            get { return m_cpu; }
            set
            {
                if(value.Length == 0)
                    value = "Unknown";
                m_cpu = value;
            }
        }

        public int RAM
        {
            get { return m_ram; }
            set
            {
                if(value > 0)
                    m_ram = value;
                else
                {
                    Console.WriteLine("Invalid RAM");
                }
            }
        }

        public int HDD
        {
            get { return m_hdd; }
            set
            {
                if(value > 0)
                    m_hdd = value;
                else
                {
                    Console.WriteLine("Invalid HDD");
                }
            }
        }

        public string ScreenResolution
        {
            get { return m_screenResolution; }
            set
            {
                if(value.Length == 0)
                    value = "Unknown";
                m_screenResolution = value;
            }
        }

        public string GPU
        {
            get { return m_gpu; }
            set
            {
                if(value.Length == 0)
                    value = "Unknown";
                m_gpu = value;
            }

        }
    

        public string OS
        {
            get { return m_os; }
            set
            {
                if(value.Length == 0)
                    value = "Unknown";
                m_os = value;
            }
        }

        public Laptop(string brand,
                      string name,
                      double price,
                      string description,
                      string cpu,
                      int ram,
                      int hdd,
                      string screenResolution,
                      string gpu,
                      string os)
            : base(brand, name, price, description, Electronics.ElectronicsType.Laptop)
        {
            this.CPU = cpu;
            this.RAM = ram;
            this.HDD = hdd;
            this.ScreenResolution = screenResolution;
            this.GPU = gpu;
            this.OS = os;
        }

        public override void ShowProduct()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Товар: Электроника(Ноутбук)");
            Console.WriteLine($"Бренд: {Brand}");
            Console.WriteLine($"Модель: {Name}");
            Console.WriteLine($"Процессор: {CPU}");
            Console.WriteLine($"Оперативная память: {RAM}");
            Console.WriteLine($"Жесткий диск: {HDD}");
            Console.WriteLine($"Разрешение экрана: {ScreenResolution}");
            Console.WriteLine($"Видеокарта: {GPU}");
            Console.WriteLine($"Операционная система: {OS}");
            Console.WriteLine($"Цена: {Price}\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Описание: {Description}");
            Console.ResetColor();
        }
    }
}
