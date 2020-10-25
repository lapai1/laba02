using System;
using System.Collections.Generic;
using System.Text;

namespace laba02
{
    class Vozvrat2
    {
        public static void VozvratPunkt2()
        {
            Console.WriteLine("Нажмите Enter, чтобы вернуться в меню \n Нажмите Пробел, чтобы вернуться в начальное меню \n Нажмите Backspace, чтобы выйти из программы");
            ConsoleKeyInfo y = Console.ReadKey(true);
            if (y.Key == ConsoleKey.Enter)
            {
                Punkt12.Punkt2();
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
