using MessagePack;

namespace MarketPlace
{
    static class PhoneSerializer
    {
        static string path = "phone.bin";
        public static void PhoneWriteToFile(in Phone phone)
        {
            if(path.Length != 0)
            {
                byte[] phoneBytes = MessagePackSerializer.Serialize(phone);

                using var fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                {
                    fileStream.Seek(0, SeekOrigin.End);
                    fileStream.Write(phoneBytes, 0, phoneBytes.Length);
                }
            } else
            {
                throw new ArgumentException("Path is empty");
            }
        }

        // Чтение из файла и возврат всех записанных элементов
        public static List<Phone> PhoneReadFromFile()
        {
            if(path.Length != 0)
            {
                byte[] phoneBytes = File.ReadAllBytes(path);
                List<Phone> phones = new List<Phone>();

                int offset = 0;
                int bytesRead = 0;
                while(offset < phoneBytes.Length)
                {
                    phones.Add(MessagePackSerializer.Deserialize<Phone>(phoneBytes.AsMemory(offset), out bytesRead));
                    offset += bytesRead;
                }

                return phones;
            } else
            {
                throw new ArgumentException("Path is empty");
            }
        }
    }
}
