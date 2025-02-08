using MessagePack;

namespace MarketPlace
{
    static class VacSerializer
    {
        static string path = "Vac.bin";
        public static void VacWriteToFile(in VacuumCleaner vac)
        {
            if(path.Length != 0)
            {
                byte[] vacBytes = MessagePackSerializer.Serialize(vac);

                using var fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                {
                    fileStream.Seek(0, SeekOrigin.End);
                    fileStream.Write(vacBytes, 0, vacBytes.Length);
                }
            } else
            {
                throw new ArgumentException("Path is empty");
            }
        }

        // Чтение из файла и возврат всех записанных элементов
        public static List<VacuumCleaner> VacReadFromFile()
        {
            if(path.Length != 0)
            {
                byte[] vacBytes = File.ReadAllBytes(path);
                List<VacuumCleaner> vacus = new List<VacuumCleaner>();

                int offset = 0;
                int bytesRead = 0;
                while(offset < vacBytes.Length)
                {
                    vacus.Add(MessagePackSerializer.Deserialize<VacuumCleaner>(vacBytes.AsMemory(offset), out bytesRead));
                    offset += bytesRead;
                }

                return vacus;
            } else
            {
                throw new ArgumentException("Path is empty");
            }
        }
    }
}
