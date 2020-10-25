using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace laba02
{
    class Punkt11
    {
        public static void Punkt1()
        {
            try
            {
                Console.WriteLine(" \n 1-добавить позицию \n 2-изменить запись \n 3-удалить запись \n Нажмите пробел ,чтобы вернуться в н.меню \n Нажмите delete, чтобы выйти из программы ");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    Exit.Vihod();
                }
                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    Menu1.Menu();
                }
                int q;
                q = Int32.Parse(Console.ReadLine());
                if (q == 1 || q == 2 || q == 3)
                {
                    List<Student> k = new List<Student>();
                    string path = @"laba02.txt";
                    StreamReader sr = new StreamReader(path);
                    string fr = sr.ReadToEnd();
                    sr.Close();
                    string[] x = fr.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
                    string[] y = x[0].Split(';');
                    for (int i = 0; i < x.Length; i++)
                    {
                        y = x[i].Split(';');
                        k.Add(new Student(y[0], y[1], y[2], y[3], y[4], y[5], y[6]));
                        Console.WriteLine($"{y[0]} ФИО:{y[1]}  Дата рождения:{ y[2]}  Институт: { y[3]}  Курс: {y[4]} Группа: {y[5] } Средний балл{ y[6] }");
                    }
                    switch (q)
                    {
                        case 1:

                            Console.WriteLine("Введите номер студента");
                            string n = Console.ReadLine();
                            Console.WriteLine("Введите ФИО студента");
                            string fio = Console.ReadLine();
                            Console.WriteLine("Введите день рождения студента");
                            string datar = Console.ReadLine();
                            Console.WriteLine("Введите институт студента");
                            string institut = Console.ReadLine();
                            Console.WriteLine("Введите группу студента");
                            string gruppa = Console.ReadLine();
                            Console.WriteLine("Введите курс студента");
                            string kurs = Console.ReadLine();
                            Console.WriteLine("Введите средний балл студента");
                            string sredniball = Console.ReadLine();
                            k.Add(new Student(n, fio, datar, institut, gruppa, kurs, sredniball));
                            Console.WriteLine("После изменения база данных имеет вид:");
                            foreach (Student student in k)
                            {
                                Console.WriteLine(student.N + "  ФИО:" + student.FIO + "  Дата рождения:" + student.Datar + "  Институт:" + student.Institut + "  Группа: " + student.Gruppa + "  " + student.Kurs + "  Средний балл:" + student.Sredniball);
                            }
                            StreamWriter sw3 = new StreamWriter(path, false);
                            int k2 = 0;
                            foreach (Student student in k)
                            {
                                k2++;
                                if (k2 != k.Count)
                                {
                                    sw3.WriteLine(student.N + ";" + student.FIO + ";" + student.Datar + ";" + student.Institut + ";" + student.Gruppa + ";" + student.Kurs + ";" + student.Sredniball);
                                }
                                else
                                {
                                    sw3.WriteLine(student.N + ";" + student.FIO + ";" + student.Datar + ";" + student.Institut + ";" + student.Gruppa + ";" + student.Kurs + ";" + student.Sredniball);
                                }
                            }
                            sw3.Close();
                            Vozvrat1.VozvratPunkt1();
                            break;
                        case 2:
                            Console.WriteLine("\nКакую строчку вы хотите изменить?");
                            int t;
                            t = Int32.Parse(Console.ReadLine());
                            string num1;
                            num1 = Convert.ToString(t);
                            Console.WriteLine("Изменить параметр:\n1 - ФИО\n2 - Дата рождения\n3 - Институт\n4 - Группа\n5 - Курс\n6 - Средний балл");
                            int o;
                            o = Int32.Parse(Console.ReadLine());

                            switch (o)
                            {
                                case 1:
                                    Console.WriteLine("Введите новое ФИО");
                                    string fio1;
                                    fio1 = Convert.ToString(Console.ReadLine());
                                    k[t - 1] = new Student(num1, fio1, k[t - 1].Datar, k[t - 1].Institut, k[t - 1].Gruppa, k[t - 1].Kurs, k[t - 1].Sredniball);
                                    Console.WriteLine("После изменений:");
                                    foreach (Student student in k)
                                    {
                                        Console.WriteLine(student.N + "  ФИО:" + student.FIO + "  Дата рождения:" + student.Datar + "  Институт:" + student.Institut + "  Группа: " + student.Gruppa + "  " + student.Kurs + "  Средний балл:" + student.Sredniball);
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Введите новый день рождения:");
                                    string dataar1;
                                    dataar1 = Convert.ToString(Console.ReadLine());
                                    k[t - 1] = new Student(num1, k[t - 1].FIO, dataar1, k[t - 1].Institut, k[t - 1].Gruppa, k[t - 1].Kurs, k[t - 1].Sredniball);
                                    Console.WriteLine("После изменений:");
                                    foreach (Student student in k)
                                    {
                                        Console.WriteLine(student.N + "  ФИО:" + student.FIO + "  Дата рождения:" + student.Datar + "  Институт:" + student.Institut + "  Группа: " + student.Gruppa + "  " + student.Kurs + "  Средний балл:" + student.Sredniball);
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Введите новый институт:");
                                    string inst1;
                                    inst1 = Convert.ToString(Console.ReadLine());
                                    k[t - 1] = new Student(num1, k[t - 1].FIO, k[t - 1].Datar, inst1, k[t - 1].Gruppa, k[t - 1].Kurs, k[t - 1].Sredniball);

                                    Console.WriteLine("После изменений:");

                                    foreach (Student student in k)
                                    {
                                        Console.WriteLine(student.N + "  ФИО:" + student.FIO + "  Дата рождения:" + student.Datar + "  Институт:" + student.Institut + "  Группа: " + student.Gruppa + "  " + student.Kurs + "  Средний балл:" + student.Sredniball);
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Введите новую группу:");
                                    string gr1;
                                    gr1 = Convert.ToString(Console.ReadLine());
                                    k[t - 1] = new Student(num1, k[t - 1].FIO, k[t - 1].Datar, k[t - 1].Institut, gr1, k[t - 1].Kurs, k[t - 1].Sredniball);
                                    Console.WriteLine("После изменений:");
                                    foreach (Student student in k)
                                    {
                                        Console.WriteLine(student.N + "  ФИО:" + student.FIO + "  Дата рождения:" + student.Datar + "  Институт:" + student.Institut + "  Группа: " + student.Gruppa + "  " + student.Kurs + "  Средний балл:" + student.Sredniball);
                                    }
                                    break;
                                case 5:
                                    Console.WriteLine("Введите новый курс:");
                                    string kurs1;
                                    kurs1 = Convert.ToString(Console.ReadLine());
                                    k[t - 1] = new Student(num1, k[t - 1].FIO, k[t - 1].Datar, k[t - 1].Institut, k[t - 1].Gruppa, kurs1, k[t - 1].Sredniball);
                                    Console.WriteLine("После изменения база данных имеет вид:");
                                    foreach (Student student in k)
                                    {
                                        Console.WriteLine(student.N + "  ФИО:" + student.FIO + "  Дата рождения:" + student.Datar + "  Институт:" + student.Institut + "  Группа: " + student.Gruppa + "  " + student.Kurs + "  Средний балл:" + student.Sredniball);
                                    }
                                    break;
                                case 6:
                                    Console.WriteLine("Введите новый балл:");
                                    string balll1;
                                    balll1 = Convert.ToString(Console.ReadLine());
                                    k[t - 1] = new Student(num1, k[t - 1].FIO, k[t - 1].Datar, k[t - 1].Institut, k[t - 1].Gruppa, k[t - 1].Kurs, balll1);
                                    Console.WriteLine("После изменения база данных имеет вид:");
                                    foreach (Student student in k)
                                    {
                                        Console.WriteLine(student.N + "  ФИО:" + student.FIO + "  Дата рождения:" + student.Datar + "  Институт:" + student.Institut + "  Группа: " + student.Gruppa + "  " + student.Kurs + "  Средний балл:" + student.Sredniball);
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Вы нажали неизвестную букву");
                                    break;
                            }
                            StreamWriter sw2 = new StreamWriter(path, false);
                            int k1 = 0;
                            foreach (Student student in k)
                            {
                                k1++;
                                if (k1 != k.Count)
                                {
                                    sw2.Write(student.N + ";" + student.FIO + ";" + student.Datar + ";" + student.Institut + ";" + student.Gruppa + ";" + student.Kurs + ";" + student.Sredniball + '\n');
                                }
                                else
                                {
                                    sw2.Write(student.N + ";" + student.FIO + ";" + student.Datar + ";" + student.Institut + ";" + student.Gruppa + ";" + student.Kurs + ";" + student.Sredniball);
                                }

                            }
                            sw2.Close();
                            Vozvrat1.VozvratPunkt1();
                            break;
                        case 3:

                            Console.WriteLine("\nКакую строчку вы хотите удалить?");
                            int u;
                            u = Int32.Parse(Console.ReadLine());
                            k.RemoveAt(u - 1);
                            Console.WriteLine("После удаления база данных имеет вид:");
                            foreach (Student student in k)
                            {
                                Console.WriteLine(student.N + "  ФИО:" + student.FIO + "  Дата рождения:" + student.Datar + "  Институт:" + student.Institut + "  Группа: " + student.Gruppa + "  " + student.Kurs + "  Средний балл:" + student.Sredniball);
                            }
                            StreamWriter sw1 = new StreamWriter(path, false);
                            int k11 = 0;
                            foreach (Student student in k)
                            {
                                k11++;
                                if (k11 != k.Count)
                                {
                                    sw1.Write(student.N + ";" + student.FIO + ";" + student.Datar + ";" + student.Institut + ";" + student.Gruppa + ";" + student.Kurs + ";" + student.Sredniball + '\n');
                                }
                                else
                                {
                                    sw1.Write(student.N + ";" + student.FIO + ";" + student.Datar + ";" + student.Institut + ";" + student.Gruppa + ";" + student.Kurs + ";" + student.Sredniball);
                                }

                            }
                            sw1.Close();
                            Vozvrat1.VozvratPunkt1();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Повторите попытку ввода");
                    Punkt1();
                }
            }
            catch
            {
                Console.WriteLine("Повторите попытку ввода");
                Punkt1();
            }
        }
    }
}
