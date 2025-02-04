
namespace MarketPlace
{
    //класс для объединения всех продуктов 
    abstract class Product : IProduct
    {
        public enum CategoryType
        {
            Food,
            Medicine,
            Electronics,
            Clothing,
            Books,
            Other
        }

        private Guid m_id;
        private string m_brand;
        private string m_name;
        private double m_price;
        private CategoryType m_category;
        private string m_description;

        public Guid Id
        {
            get { return m_id; }
        }

        public string Name
        {
            get { return m_name; }
            set
            {
                if(value.Length > 0)
                    m_name = value;
                else
                {
                    Console.WriteLine("Name must be at least 1 character long");
                }
            }
        }

        public string Brand
        {
            get { return m_brand; }
            set
            {
                if(value.Length > 0)
                    m_brand = value;
                else
                {
                    Console.WriteLine("Name must be at least 1 character long");
                }
            }
        }

        public CategoryType Category
        {
            get { return m_category; }
            set
            {
                m_category = value;
            }
        }

        public double Price
        {
            get { return m_price; }
            set
            {
                if(value > 0)
                    m_price = value;
                else
                {
                    Console.WriteLine("Price must be greater than or equal to 0");
                }
            }
        }

        public string Description { get; set; }

        public Product(string brand,
                       string name,
                       double price,
                       CategoryType category,
                       string description)
        {
            Brand = brand;
            Name = name;
            Price = price;
            Category = category;
            Description = description;
            m_id = Guid.NewGuid();

        }

        abstract public void ShowProduct();
        public static void DrawTable()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string item = "Производитель";
            var margin = 30 - item.Length; //определяю отступы для выравнивания
            Console.Write($"{item}");
            var cursorPosition = Console.GetCursorPosition();
            Console.SetCursorPosition(cursorPosition.Left += margin, cursorPosition.Top);

            item = "Название товара";
            margin = 30 - item.Length;
            Console.Write($"{item}");
            cursorPosition = Console.GetCursorPosition();
            Console.SetCursorPosition(cursorPosition.Left += margin, cursorPosition.Top);

            item = "Цена";
            Console.WriteLine($"{item}");
            Console.ResetColor();
        }
        public void ShowProductSmallInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write($"{Brand}");
            var margin = 30 - Brand.Length; //определяю отступы для выравнивания
            var cursorPosition = Console.GetCursorPosition(); //определяю текущую позицию курсора чтоб потом выровнять следующий элемент
            Console.SetCursorPosition(cursorPosition.Left += margin, cursorPosition.Top);

            Console.Write($"{Name}");
            margin = 30 - Name.Length;
            cursorPosition = Console.GetCursorPosition();
            Console.SetCursorPosition(cursorPosition.Left += margin, cursorPosition.Top);

            Console.WriteLine($"{Price.ToString("F2")} USD"); //вывожу цену с двумя знаками после запятой

            Console.ResetColor();
        }

        public virtual string ToString()
        {
            return $"Производитель: {Brand}\nНазвание товара: {Name}\nЦена: {Price.ToString("F2")} USD\nОписание: {Description}";
        }
    }
}
