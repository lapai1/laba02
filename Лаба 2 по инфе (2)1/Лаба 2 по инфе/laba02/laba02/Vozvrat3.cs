﻿using System;
using System.Collections.Generic;
using System.Text;

namespace laba02
{
    class Vozvrat3
    {
        public static void VozvratPunkt3()
        {
            Console.WriteLine("Нажмите Enter, чтобы вернуться в меню \n Нажмите Пробел, чтобы вернуться в начальное меню \n Нажмите Backspace, чтобы выйти из программы");
            ConsoleKeyInfo y = Console.ReadKey(true);
            if (y.Key == ConsoleKey.Enter)
            {
                Punkt13.Punkt3();

            }
            if (y.Key == ConsoleKey.Spacebar)
            {
                Menu1.Menu();
            }
            if (y.Key == ConsoleKey.Backspace)
            {
                Exit.Vihod();
            }
        }
    }
}
