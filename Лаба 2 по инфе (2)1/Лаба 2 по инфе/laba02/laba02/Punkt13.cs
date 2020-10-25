using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace laba02
{
    class Punkt13
    {
        public static void Punkt3()
        {
            List<Student> k = new List<Student>();
            string path = @"laba02.txt";
            StreamReader sr = new StreamReader(path);
            string fr = sr.ReadToEnd();
            sr.Close();
            string[] x = fr.Split('\n');
            string[] y = x[0].Split(';');
            for (int i = 0; i < x.Length; i++)
            {
                y = x[i].Split(';');
                k.Add(new Student(y[0], y[1], y[2], y[3], y[4], y[5], y[6]));
                Console.WriteLine($"{y[0]} ФИО:{y[1]}  Дата рождения:{ y[2]}  Институт: { y[3]}  Курс: {y[4]} Группа: {y[5] } Средний балл{ y[6] }");
            }
            try
            {
                Console.WriteLine("По какому параметру делать поиск? \n 1 - ФИО, 2 - ДР \n Нажмите Пробел, чтобы вернуться в начальное меню \n Нажмите Backspace, чтобы выйти из программы");
                ConsoleKeyInfo y1 = Console.ReadKey(true);
                if (y1.Key == ConsoleKey.Spacebar)
                {
                    Menu1.Menu();
                }
                if (y1.Key == ConsoleKey.Backspace)
                {
                    Exit.Vihod();
                }
                int q;
                q = Int32.Parse(Console.ReadLine());
                
                    switch (q)
                    {
                        case 1:
                            try
                            {
                                string f;
                                Console.WriteLine("Введите ФИО студента, которого нужно найти");
                                f = Convert.ToString(Console.ReadLine());
                                Student found = k.Find(item => item.FIO == f);
                                Console.WriteLine("Найдено по вашему запросу:\n{0}/ФИО:{1}/Дата рождения:{2}/Институт:{3}/Группа:{4}/{5}/Средний балл:{6}", found.N, found.FIO, found.Datar, found.Institut, found.Gruppa, found.Kurs, found.Sredniball);
                                Vozvrat3.VozvratPunkt3();
                            }
                            catch
                            {
                                Console.WriteLine("Такого студента не существует, повторите попытку ввода");
                                Punkt3();
                            }
                            break;
                        case 2:
                            try
                            {
                                string k11;
                                Console.WriteLine("Введите ДР студента, которого нужно найти");
                                k11 = Convert.ToString(Console.ReadLine());
                                Student foun = k.Find(it => it.Datar == k11);
                                Console.WriteLine("Найдено по вашему запросу:");
                                Console.WriteLine("{0}/ФИО:{1}/Дата рождения:{2}/Институт:{3}/Группа:{4}/{5}/Средний балл:{6}", foun.N, foun.FIO, foun.Datar, foun.Institut, foun.Gruppa, foun.Kurs, foun.Sredniball);
                                Vozvrat3.VozvratPunkt3();
                            }
                            catch
                            {
                                Console.WriteLine("Такого студента не существует, повторите попытку ввода");
                                Punkt3();
                            }
                            break;
                    default:
                        Console.WriteLine("Вы нажали неизвестную букву");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Повторите попытку ввода");
                Punkt3();
            }
        }
    }
}
