

using MessagePack;

namespace MarketPlace
{
    [MessagePackObject(keyAsPropertyName: true)]
    internal class Book : Product
    {        
        private string m_author;
        private string m_genre;

        public string Author
        {
            get { return m_author; }
            set { m_author = value; }
        }

        public string Genre
        {
            get { return m_genre; }
            set { m_genre = value; }
        }

        public Book(string brand,
                    string name,
                    double price,
                    string description,
                    string author,
                    string genre)
            : base(brand,
                  name,
                  price,
                  Product.CategoryType.Books,
                  description)
        {
            Author = author;
            Genre = genre;
        }
        public override void ShowProduct()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Товар: Книги");
            Console.WriteLine($"Издатель: {Brand}");
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Жанр: {Genre}");
            Console.WriteLine($"Price: {Price}\n\n");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Описание: {Description}");
            Console.ResetColor();
        }

        public override string ToString()
        {
            return $"Книги: {Brand} {Name} {Author} {Genre} {Price} {Description}";
        }

        public override void Serialize()
        {
            BookSerializer.BookWriteToFile(this);
        }
    }
}
