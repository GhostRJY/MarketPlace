using MessagePack;


namespace MarketPlace
{

    static class FoodSerializer
    {
        static string path = "food.bin";
        public static void FoodWriteToFile(in Foods food)
        {
            if(path.Length != 0)
            {
                byte[] foodBytes = MessagePackSerializer.Serialize(food);

                using var fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                {
                    fileStream.Seek(0, SeekOrigin.End);
                    fileStream.Write(foodBytes, 0, foodBytes.Length);
                }
            } else
            {
                throw new ArgumentException("Path is empty");
            }
        }

        // Чтение из файла и возврат всех записанных элементов
        public static List<Foods> FoodReadFromFile()
        {
            if(path.Length != 0)
            {
                byte[] foodBytes = File.ReadAllBytes(path);
                List<Foods> foods = new List<Foods>();

                int offset = 0;
                int bytesRead = 0;
                while(offset < foodBytes.Length)
                {
                    Foods food = MessagePackSerializer.Deserialize<Foods>(foodBytes.AsMemory(offset),out bytesRead);
                    foods.Add(food);
                    offset += bytesRead;
                }

                return foods;
            } else
            {
                throw new ArgumentException("Path is empty");
            }
        }
    }
}
