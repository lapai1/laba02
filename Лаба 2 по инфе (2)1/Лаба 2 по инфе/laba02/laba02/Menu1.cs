using System;
using System.Collections.Generic;
using System.Text;

namespace laba02
{
    class Menu1
    {
        public static void Menu()
        {
            try
            {
                Console.WriteLine("\nДействия с БД:\n1 - добавление, изменение, удаление записи БД\n2 - прямая и обратная сортировка по полям: ФИО, Дата рождения" +"\n3 - поиск элемента по полям: ФИО, Дата рождения\n4 - нахождение MAX, MIN, среднего значения и суммы по полю: Средний балл ");
                int x;
                x = Int32.Parse(Console.ReadLine());
                if (x == 1 || x == 2 || x == 3 || x == 4)
                {
                    switch (x)
                    {
                        case 1:
                            Punkt11.Punkt1();
                            break;
                        case 2:
                            Punkt12.Punkt2();
                            break;
                        case 3:
                            Punkt13.Punkt3();
                            break;
                        case 4:
                            Punkt14.Punkt4();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Повторите попытку ввода");
                    Menu();
                }
            }
            catch
            {
                Console.WriteLine("Повторите попытку ввода");
                Menu();
            }
        }
    }
}
