using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    static class ClothingSerializer
    {
        static string path = "cloth.bin";
        public static void ClothWriteToFile(in Clothing cloth)
        {
            if(path.Length != 0)
            {
                byte[] clothBytes = MessagePackSerializer.Serialize(cloth);

                using var fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                {
                    fileStream.Seek(0, SeekOrigin.End);
                    fileStream.Write(clothBytes, 0, clothBytes.Length);
                }
            } else
            {
                throw new ArgumentException("Path is empty");
            }
        }

        // Чтение из файла и возврат всех записанных элементов
        public static List<Clothing> ClothReadFromFile()
        {
            if(path.Length != 0)
            {
                byte[] clothBytes = File.ReadAllBytes(path);
                List<Clothing> cloth = new List<Clothing>();

                int offset = 0;
                int bytesRead = 0;
                while(offset < clothBytes.Length)
                {
                    cloth.Add(MessagePackSerializer.Deserialize<Clothing>(clothBytes.AsMemory(offset), out bytesRead));
                    offset += bytesRead;
                }

                return cloth;
            } else
            {
                throw new ArgumentException("Path is empty");
            }
        }
    }
}
