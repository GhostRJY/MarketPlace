using MessagePack;


namespace MarketPlace
{
    [MessagePackObject(keyAsPropertyName: true)]
    internal class VacuumCleaner : Electronics
    {
        private int m_power;
        public int Power
        {
            get { return m_power; }
            set
            {
                if(value > 0)
                    m_power = value;
                else
                {
                    Console.WriteLine("Invalid power value");
                }
            }
        }

        public VacuumCleaner(string brand,
                            string name,
                            double price,
                            string description,
                            int power)
            : base(brand, name, price, description, Electronics.ElectronicsType.ConsumerElectronics)
        {
            this.Power = power;
        }
        public override void ShowProduct()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Товар: Бытовая техника(Пылесос)");
            Console.WriteLine($"Бренд: {Brand}");
            Console.WriteLine($"Модель: {Name}");
            Console.WriteLine($"Мощность: {Power}");
            Console.WriteLine($"Цена: {Price}\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Описание: {Description}");
            Console.ResetColor();
        }

        public override string ToString()
        {
            return $"Пылесос: {Brand} {Name} {Power} {Price} {Description}";
        }

        public override void Serialize()
        {
            VacSerializer.VacWriteToFile(this);
        }
    }
}
