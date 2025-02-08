using MessagePack;

namespace MarketPlace
{
    internal class CPUSerializer
    {
        static string path = "CPU.bin";
        public static void CPUWriteToFile(in CPU cpu)
        {
            if(path.Length != 0)
            {
                byte[] cpuBytes = MessagePackSerializer.Serialize(cpu);

                using var fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                {
                    fileStream.Seek(0, SeekOrigin.End);
                    fileStream.Write(cpuBytes, 0, cpuBytes.Length);
                }
            } else
            {
                throw new ArgumentException("Path is empty");
            }
        }

        // Чтение из файла и возврат всех записанных элементов
        public static List<CPU> CPUReadFromFile()
        {
            if(path.Length != 0)
            {
                byte[] cpuBytes = File.ReadAllBytes(path);
                List<CPU> cpus = new List<CPU>();

                int offset = 0;
                int bytesRead = 0;
                while(offset < cpuBytes.Length)
                {
                    cpus.Add(MessagePackSerializer.Deserialize<CPU>(cpuBytes.AsMemory(offset), out bytesRead));
                    offset += bytesRead;
                }

                return cpus;
            } else
            {
                throw new ArgumentException("Path is empty");
            }
        }
    }
}
