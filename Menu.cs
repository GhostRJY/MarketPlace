using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    //класс для работы с меню
    internal class Menu
    {
        private List<string> m_options;

        public Menu()
        {
            m_options = new List<string>();

            m_options.Add("Регистрация");
            m_options.Add("Показать товар");
            m_options.Add("Заказать товар");
            m_options.Add("Посмотреть заказы");
            m_options.Add("Exit");
        }

        private void AddOption(in string option)
        {
            m_options.Add(option);
        }

        public void ShowMenu()
        {
            for (int i = 0; i < m_options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {m_options[i]}");
            }
            Console.WriteLine();
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                ShowMenu();
                Console.Write("Выберите пункт меню: ");
                try
                {
                    var choice = Convert.ToInt32(Console.ReadLine());
                    
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Регистрация");
                            break;
                        case 2:
                            Console.WriteLine("Посмотреть товары");
                            break;
                        case 3:
                            Console.WriteLine("Заказать товар");
                            break;
                        case 4:
                            Console.WriteLine("Посмотреть заказы");
                            break;
                        case 5:
                            Console.WriteLine("Exit");
                            return;
                        default:
                            Console.WriteLine("Неверный пункт меню");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неверный пункт меню");
                }
            }
        }
    }
}
