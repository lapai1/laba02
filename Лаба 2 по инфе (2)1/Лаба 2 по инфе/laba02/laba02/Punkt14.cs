using System;
using System.Collections.Generic;
using System.IO;
namespace laba02
{
    class Punkt14
    {
        public static void Punkt4()
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

            double srbl = 0;
            int count = 0;
            int sum = 0;
            int value = 0;
            int max = 0;
            int min = 100;
            foreach (Student student in k)
            {
                string sredniball = student.Sredniball;
                value = Int32.Parse(sredniball);
                sum += value;
                if (Int32.Parse(sredniball) > max)
                {
                    max = Int32.Parse(sredniball);
                }
                string sredniball1 = student.Sredniball;
                if (Int32.Parse(sredniball1) < min)
                {
                    min = Int32.Parse(sredniball1);
                }
                count++;
            }
            srbl = sum / count;
         
            Console.WriteLine("\nМаксимальный балл средний балл:" + max);
            Console.WriteLine("Минимальный средний балл:" + min);
            Console.WriteLine("Средний балл студентов:" + srbl);
            Console.WriteLine("Сумма баллов:" + sum);
            Vozvrat4.VozvratPunkt4();
        }
    }
}
