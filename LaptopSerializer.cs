using MessagePack;

namespace MarketPlace
{
    static class LaptopSerializer
    {
        static string path = "Laptop.bin";
        public static void LaptopWriteToFile(in Laptop laptop)
        {
            if(path.Length != 0)
            {
                byte[] laptopBytes = MessagePackSerializer.Serialize(laptop);

                using var fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                {
                    fileStream.Seek(0, SeekOrigin.End);
                    fileStream.Write(laptopBytes, 0, laptopBytes.Length);
                }
            } else
            {
                throw new ArgumentException("Path is empty");
            }
        }

        // Чтение из файла и возврат всех записанных элементов
        public static List<Laptop> FoodReadFromFile()
        {
            if(path.Length != 0)
            {
                byte[] laptopBytes = File.ReadAllBytes(path);
                List<Laptop> laptops = new List<Laptop>();

                int offset = 0;
                int bytesRead = 0;
                while(offset < laptopBytes.Length)
                {
                    laptops.Add(MessagePackSerializer.Deserialize<Laptop>(laptopBytes.AsMemory(offset), out bytesRead));
                    offset += bytesRead;
                }

                return laptops;
            } else
            {
                throw new ArgumentException("Path is empty");
            }
        }
    }
}
