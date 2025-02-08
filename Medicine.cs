

using MessagePack;

namespace MarketPlace
{
    [MessagePackObject(keyAsPropertyName: true)]
    internal class Medicine : Product
    {
        string m_medicineType;

        public string MedicineType
        {
            get { return m_medicineType; }
            set
            {
                if (value.Length > 0)
                    m_medicineType = value;
                else
                {
                    Console.WriteLine("Medicine type must be at least 1 character long");
                }
            }
        }

        public Medicine(string brand,
                        string name,
                        double price,
                        string description,
                        string medicineType)
            : base(brand,
                  name,
                  price,
                  Product.CategoryType.Medicine,
                  description)
        {
            MedicineType = medicineType;
        }

        public override void ShowProduct()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Товар: Лекарства");
            Console.WriteLine($"Производитель: {Brand}");
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Тип лекарства: {MedicineType}");
            Console.WriteLine($"Price: {Price}\n\n");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Описание: {Description}");
            Console.ResetColor();
        }

        public override string ToString()
        {
            return $"Лекарства: {Brand} {Name} {MedicineType} {Price} {Description}";
        }

        public override void Serialize()
        {
            MedicineSerializer.MedicineWriteToFile(this);
        }

    }
}
