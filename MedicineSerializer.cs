using MessagePack;


namespace MarketPlace
{
    static class MedicineSerializer
    {
        static string path = "medicine.bin";
        public static void MedicineWriteToFile(in Medicine medicine)
        {
            if(path.Length != 0)
            {
                byte[] foodBytes = MessagePackSerializer.Serialize(medicine);

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
        public static List<Medicine> MedicineReadFromFile()
        {
            if(path.Length != 0)
            {
                byte[] medicineBytes = File.ReadAllBytes(path);
                List<Medicine> medicine = new List<Medicine>();

                int offset = 0;
                int bytesRead = 0;
                while(offset < medicineBytes.Length)
                {                    
                    medicine.Add(MessagePackSerializer.Deserialize<Medicine>(medicineBytes.AsMemory(offset), out bytesRead));
                    offset += bytesRead;
                }

                return medicine;
            } else
            {
                throw new ArgumentException("Path is empty");
            }
        }
    }
}
