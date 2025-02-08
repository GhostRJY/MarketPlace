using MessagePack;

namespace MarketPlace
{
    [MessagePackObject(keyAsPropertyName: true)]
    internal class GPU : Electronics
    {        
        private string m_core;
        private int m_frequency;
        
        private int m_memorySize;        
        private int m_memoryBus;
        private int m_memoryClock;

        public string Core
        {
            get { return m_core; }
            set
            {
                if(value.Length == 0)
                    value = "Unknown";
                m_core = value;
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
                

        public int MemorySize
        {
            get { return m_memorySize; }
            set
            {
                if(value > 0)
                    m_memorySize = value;
                else
                {
                    Console.WriteLine("Invalid memory size");
                }
            }
        }

        public int MemoryBus
        {
            get { return m_memoryBus; }
            set
            {
                if(value > 0)
                    m_memoryBus = value;
                else
                {
                    Console.WriteLine("Invalid memory bus");
                }
            }
        }

        public int MemoryClock
        {
            get { return m_memoryClock; }
            set
            {
                if(value > 0)
                    m_memoryClock = value;
                else
                {
                    Console.WriteLine("Invalid memory clock");
                }
            }
        }

        public GPU(string brand,
            string name,
            double price,
            string description,
            string core,
            int frequency,            
            int memorySize,
            int memoryBus,
            int memoryClock)
            : base(brand, name, price, description, Electronics.ElectronicsType.ComputerParts)
        {
            Core = core;
            Frequency = frequency;            
            MemorySize = memorySize;
            MemoryBus = memoryBus;
            MemoryClock = memoryClock;
        }

        public override void ShowProduct()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("Товар: Компьютерные компоненты(Видеокарта)");
            Console.WriteLine($"Бренд: {Brand}");
            Console.WriteLine($"Модель: {Name}");
            Console.WriteLine($"Ядро: {Core}");
            Console.WriteLine($"Частота: {Frequency} MHz");
            Console.WriteLine($"Объем памяти: {MemorySize} Gb");
            Console.WriteLine($"Шина памяти: {MemoryBus} bit");
            Console.WriteLine($"Частота памяти: {MemoryClock} MHz");
            Console.WriteLine($"Цена: {Price}\n\n");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Описание: {Description}");
            Console.ResetColor();
        }

        public override string ToString()
        {
            return $"Видеокарта: {Brand} {Name} {Core} {Frequency} {MemorySize} {MemoryBus} {MemoryClock} {Price} {Description}";
        }

        public override void Serialize()
        {
            GPUSerializer.GPUWriteToFile(this);
        }
    }
}
