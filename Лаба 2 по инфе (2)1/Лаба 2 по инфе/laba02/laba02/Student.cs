using System;
using System.Collections.Generic;
using System.Text;

namespace laba02
{
    public class Student
    {
        public string N;
        public string FIO;
        public string Datar;
        public string Institut;
        public string Gruppa;
        public string Kurs;
        public string Sredniball;
        public Student(string n, string fio, string datar, string institut, string gruppa, string kurs, string sredniball)
        {
            N = n; FIO = fio; Datar = datar; Institut = institut; Gruppa = gruppa; Kurs = kurs; Sredniball = sredniball;
        }

    }
}
