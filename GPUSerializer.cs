using MessagePack;

namespace MarketPlace
{
    static class GPUSerializer
    {
        static string path = "GPU.bin";
        public static void GPUWriteToFile(in GPU gpu)
        {
            if(path.Length != 0)
            {
                byte[] gpuBytes = MessagePackSerializer.Serialize(gpu);

                using var fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                {
                    fileStream.Seek(0, SeekOrigin.End);
                    fileStream.Write(gpuBytes, 0, gpuBytes.Length);
                }
            } else
            {
                throw new ArgumentException("Path is empty");
            }
        }

        // Чтение из файла и возврат всех записанных элементов
        public static List<GPU> GPUReadFromFile()
        {
            if(path.Length != 0)
            {
                byte[] gpuBytes = File.ReadAllBytes(path);
                List<GPU> laptops = new List<GPU>();

                int offset = 0;
                int bytesRead = 0;
                while(offset < gpuBytes.Length)
                {
                    laptops.Add(MessagePackSerializer.Deserialize<GPU>(gpuBytes.AsMemory(offset), out bytesRead));
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