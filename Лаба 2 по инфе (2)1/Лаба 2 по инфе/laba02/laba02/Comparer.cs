using System;
using System.Collections.Generic;
using System.Text;

namespace laba02
{
    interface IComparer
    {
        int Compare(object kt1, object kt2);

    }
    class StudentCompereNumber : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            string nb1 = s1.N;
            string nb2 = s2.N;
            if (Int32.Parse(nb1) > Int32.Parse(nb2))
                return 1;
            else if (Int32.Parse(nb1) < Int32.Parse(nb2))
                return -1;
            else
                return 0;

        }
    }
    class StudentComparerfIO : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            if (s1.FIO.ToCharArray()[0] > s2.FIO.ToCharArray()[0])
                return 1;
            else if (s1.FIO.ToCharArray()[0] < s2.FIO.ToCharArray()[0])
                return -1;
            else
                return 0;
        }
    }
    class StudentComparerFiO : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            if (s2.FIO.ToCharArray()[0] < s1.FIO.ToCharArray()[0])
                return -1;
            else if (s2.FIO.ToCharArray()[0] > s1.FIO.ToCharArray()[0])
                return 1;
            else
                return 0;
        }
    }

    class StudentComparerDATAr : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            string[] DATAr1 = s1.Datar.Split('.');
            string[] DATAr2 = s1.Datar.Split('.');
            if (Int32.Parse(DATAr1[2]) == Int32.Parse(DATAr2[2]))
            {
                if (Int32.Parse(DATAr1[1]) == Int32.Parse(DATAr2[1]))
                {
                    if (Int32.Parse(DATAr1[0]) > Int32.Parse(DATAr2[0]))
                        return 1;
                    else if (Int32.Parse(DATAr1[0]) < Int32.Parse(DATAr2[0]))
                        return -1;
                    else
                        return 0;
                }
                else
                {
                    if (Int32.Parse(DATAr1[1]) > Int32.Parse(DATAr2[1]))
                        return 1;
                    else if (Int32.Parse(DATAr1[1]) < Int32.Parse(DATAr2[1]))
                        return -1;
                    else
                        return 0;
                }
            }
            else
            {
                if (Int32.Parse(DATAr1[2]) > Int32.Parse(DATAr2[2]))
                    return 1;
                else if (Int32.Parse(DATAr1[2]) < Int32.Parse(DATAr2[2]))
                    return -1;
                else
                    return 0;
            }
        }
    }
    class StudentComparerDATArr : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            string[] DATAr1 = s1.Datar.Split('.');
            string[] DATAr2 = s2.Datar.Split('.');
            if (Int32.Parse(DATAr2[2]) == Int32.Parse(DATAr1[2]))
            {
                if (Int32.Parse(DATAr2[1]) == Int32.Parse(DATAr1[1]))
                {
                    if (Int32.Parse(DATAr2[0]) < Int32.Parse(DATAr1[0]))
                        return -1;
                    else if (Int32.Parse(DATAr2[0]) > Int32.Parse(DATAr1[0]))
                        return 1;
                    else
                        return 0;
                }
                else
                {
                    if (Int32.Parse(DATAr2[1]) < Int32.Parse(DATAr1[1]))
                        return -1;
                    else if (Int32.Parse(DATAr2[1]) > Int32.Parse(DATAr1[1]))
                        return 1;
                    else
                        return 0;
                }
            }
            else
            {
                if (Int32.Parse(DATAr2[2]) < Int32.Parse(DATAr1[2]))
                    return -1;
                else if (Int32.Parse(DATAr2[2]) > Int32.Parse(DATAr1[2]))
                    return 1;
                else
                    return 0;
            }
        }
    }
}
