
namespace MarketPlace
{
    internal class Phone : Electronics
    {
        private int m_ram;
        private string m_cpu;
        private int m_frequency;
        private string m_os;

        public int Ram
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

        public string Cpu
        {
            get
            {
                return m_cpu;
            }
            set
            {
                if(value.Length == 0)
                    value = "Unknown";
                m_cpu = value;
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

        public string Os
        {
            get { return m_os; }
            set
            {
                if(value.Length == 0)
                    value = "Unknown";
                m_os = value;
            }
        }

        public Phone(string brand,
                     string name,
                     double price,
                     string description,
                     int ram,
                     string cpu,
                     int frequency,
                     string os)
            : base(brand, name, price, description, Electronics.ElectronicsType.Phone)
        {
            Ram = ram;
            Cpu = cpu;
            Frequency = frequency;
            Os = os;
        }

        public override void ShowProduct()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Товар: Электроника(Телефон)");
            Console.WriteLine($"Бренд: {Brand}");
            Console.WriteLine($"Модель: {Name}");
            Console.WriteLine($"Оперативная память: {Ram}");
            Console.WriteLine($"Процессор: {Cpu}");
            Console.WriteLine($"Частота: {Frequency}");
            Console.WriteLine($"Операционная система: {Os}");
            Console.WriteLine($"Цена: {Price}\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Описание: {Description}");
            Console.ResetColor();
        }
    }
}
