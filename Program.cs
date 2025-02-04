namespace MarketPlace
{
    internal class Program
    {
        //тест формирования списка товаров
        static void CreateItems(ref List<IProduct> itemList)
        {
            itemList.Add(FoodsCreator.CreateFood("Ваш", "Помидор", 3.77, "Очень вкусный помидор", 250, DateTime.Parse("10.05.2025")));
            itemList.Add(FoodsCreator.CreateFood("Наш", "Огурец", 2.77, "Очень вкусный огурец", 150, DateTime.Parse("05.06.2025")));
            itemList.Add(FoodsCreator.CreateFood("ненаш", "Картофель", 1.77, "Очень вкусный картофель", 350, DateTime.Parse("30.08.2025")));

            itemList.Add(MedicineCreator.CreateMedicine("LAN", "Omega-3", 10.00, "Рыбий жир", "Vitamine"));
            itemList.Add(MedicineCreator.CreateMedicine("Здоровье", "B6", 15.60, "Витамин группы B", "Vitamine"));

            itemList.Add(BookCreator.CreateBook("Издательство", "Чистая Архитектура", 20.00, "путеводитель в мир прекрасного Объектно Ориентированного Проэктирования", "Дядюшка Боб", "Научная литература"));
            
            itemList.Add(ClothingCreator.CreateClothing("Lora Piano", "Штаны", 1000.00, "Штаны и штаны", 48));

            itemList.Add(PhoneCreator.CreatePhone("Apple", "IPhone", 1000.00, "Сбился уже со счета какой", 8, "M4", 1600, "IOS"));
            itemList.Add(PhoneCreator.CreatePhone("Samsung", "Galaxy S25", 1100.00, "Аналогично", 16, "SnapDragon", 2000, "Android"));

            itemList.Add(LaptopCreator.CreateLaptop("Apple", "MacBook pro", 3000.00, "Что-то очень дорого", "M5", 32, 2048, "2560x1440", "NVidia Geforce 5090", "MacOS"));
            itemList.Add(LaptopCreator.CreateLaptop("Asus", "ZenBook", 1500.00, "Дешевка", "Intel Core i9", 32, 1024, "1920x1080", "NVidia Geforce 3080", "Windows"));

            itemList.Add(VacCreator.CreateVac("Karcher", "K60", 150.00, "Пылесос сос сос сос", 2500));

            itemList.Add(CPUCreator.CreateCPU("AMD", "Ryzen 9", 400, "Что-то многообещающее", "AM4", 12, 64, 4000));
            itemList.Add(CPUCreator.CreateCPU("Intel", "Core i9", 500, "Что-то немногообещающее", "LGA1200", 16, 128, 5000));

            itemList.Add(GPUCreator.CreateGPU("NVidia", "Geforce 3080", 800, "видеокарта", "GP100", 2010, 10, 382, 10000));
            itemList.Add(GPUCreator.CreateGPU("AMD", "Radeon 6900", 900, "видеокарта", "RDNA2", 2020, 16, 512, 12000));


        }

        //тест записи товара в файл
        static void WriteItemToFile(in List<IProduct> itemList)
        {
            //using(StreamWriter sw = new StreamWriter("items.txt"))
            //{
            //    foreach(var item in itemList)
            //    {
            //        sw.WriteLine(item.ToString());
            //    }
            //}
            
            //Запись в файл одного товара
            FileProductWriter.WriteProductToFile(itemList[0]);

            //Запись в файл всех товаров
            FileProductWriter.WriteAllProductsToFile(itemList);
        }

        static void ShowItems(in List<IProduct> itemList)
        {
            Product.DrawTable();
            foreach(var item in itemList)
            {
                item.ShowProductSmallInfo();
                Console.WriteLine();
            }

            //foreach(var item in itemList)
            //{
            //    item.ShowProduct();
            //    Console.WriteLine();
            //}
        }

        static void Main(string[] args)
        {
            Menu menu = new Menu();
            List<IProduct> itemList = new List<IProduct>();

            CreateItems(ref itemList);
            ShowItems(itemList);
            WriteItemToFile(itemList);

            //menu.Run();

        }
    }
}
