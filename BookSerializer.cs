using MessagePack;

namespace MarketPlace
{
    static class BookSerializer
    {
        static string path = "book.bin";
        public static void BookWriteToFile(in Book book)
        {
            if(path.Length != 0)
            {
                byte[] bookBytes = MessagePackSerializer.Serialize(book);

                using var fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                {
                    fileStream.Seek(0, SeekOrigin.End);
                    fileStream.Write(bookBytes, 0, bookBytes.Length);
                }
            } else
            {
                throw new ArgumentException("Path is empty");
            }
        }

        // Чтение из файла и возврат всех записанных элементов
        public static List<Book> BookReadFromFile()
        {
            if(path.Length != 0)
            {
                byte[] bookBytes = File.ReadAllBytes(path);
                List<Book> books = new List<Book>();

                int offset = 0;
                int bytesRead = 0;
                while(offset < bookBytes.Length)
                {
                    books.Add(MessagePackSerializer.Deserialize<Book>(bookBytes.AsMemory(offset), out bytesRead));
                    offset += bytesRead;
                }

                return books;
            } else
            {
                throw new ArgumentException("Path is empty");
            }
        }
    }
}
