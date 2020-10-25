using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace laba02
{
    class Punkt12
    {
        public static void Punkt2()
        {
            Console.WriteLine("До сортировки:");
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
                Console.WriteLine("По какому параметру сортировать? \n 1 - по ФИО \n 2 - по ДР \n Нажмите Пробел, чтобы вернуться в начальное меню \n Нажмите Backspace, чтобы выйти из программы");
                ConsoleKeyInfo b1 = Console.ReadKey(true);
                if (b1.Key == ConsoleKey.Spacebar)
                {
                    Menu1.Menu();
                }
                if (b1.Key == ConsoleKey.Backspace)
                {
                    Exit.Vihod();
                }
                int q;
                q = Int32.Parse(Console.ReadLine());
                switch (q)
                {
                    case 1:
                        k.Sort(new StudentComparerfIO());
                        Console.WriteLine("Прямая сортировки:");
                        foreach (Student student in k)
                        {
                            Console.WriteLine(student.N + "/ФИО:" + student.FIO + "/Дата рождения:" + student.Datar + "/Институт:" + student.Institut + "/Группа:" + student.Gruppa + "/" + student.Kurs + "/Средний балл:" + student.Sredniball);
                        }
                        k.Sort(new StudentComparerFiO());
                        Console.WriteLine("Прямая сортировки:");
                        foreach (Student student in k)
                        {
                            Console.WriteLine(student.N + "/ФИО:" + student.FIO + "/Дата рождения:" + student.Datar + "/Институт:" + student.Institut + "/Группа:" + student.Gruppa + "/" + student.Kurs + "/Средний балл:" + student.Sredniball);
                        }
                        Vozvrat2.VozvratPunkt2();
                        break;
                    case 2:
                        k.Sort(new StudentComparerDATAr());
                        Console.WriteLine("Прямая сортировки:");
                        foreach (Student student in k)
                        {
                            Console.WriteLine(student.N + "/ФИО:" + student.FIO + "/Дата рождения:" + student.Datar + "/Институт:" + student.Institut + "/Группа:" + student.Gruppa + "/" + student.Kurs + "/Средний балл:" + student.Sredniball);
                        }
                        k.Sort(new StudentComparerDATArr());
                        Console.WriteLine("Прямая сортировки:");
                        foreach (Student student in k)
                        {
                            Console.WriteLine(student.N + "/ФИО:" + student.FIO + "/Дата рождения:" + student.Datar + "/Институт:" + student.Institut + "/Группа:" + student.Gruppa + "/" + student.Kurs + "/Средний балл:" + student.Sredniball);
                        }
                        Vozvrat2.VozvratPunkt2();
                        break;
                    default:
                        Console.WriteLine("Вы нажали неизвестную букву");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Повторите попытку ввода");
                Punkt2();
            }
        }
    }
}
