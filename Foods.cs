
namespace MarketPlace
{
    internal class Foods : Product
    {
                
        
        private int m_calories;
        private DateTime m_expirationDate;

        public int Calories
        {
            get { return m_calories; }
            
            set 
            { 
                if(value>=0)
                    m_calories = value;
                else
                {
                    Console.WriteLine("Calories must be greater than or equal to 0");
                }
            }
        }

        public DateTime ExpirationDate
        {
            get { return m_expirationDate; }
            set
            {
                if (value >= DateTime.Now)
                    m_expirationDate = value;
                else
                {
                    Console.WriteLine("Expiration date must be greater than or equal to today");
                }
            }
        }

        public Foods(string brand,
                     string name,            
                     double price,                     
                     string description,
                     int calories,
                     DateTime expirationDate)
                     
            : base(brand,
                  name,
                  price,
                  Product.CategoryType.Food,
                  description)
        {
            Calories = calories;
            ExpirationDate = expirationDate;
        }

        public override void ShowProduct()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Товар: Продукты питания");
            Console.WriteLine($"Производитель: {Brand}");
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Кол-во калорий: {Calories}");
            Console.WriteLine($"Срок годности: {ExpirationDate}");
            Console.WriteLine($"Price: {Price}");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Описание: {Description}\n");
            Console.ResetColor();
        }

    }
}
