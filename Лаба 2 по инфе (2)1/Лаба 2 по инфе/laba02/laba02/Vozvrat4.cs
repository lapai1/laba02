using System;
using System.Collections.Generic;
using System.Text;

namespace laba02
{
    class Vozvrat4
    {
        public static void VozvratPunkt4()
        {
            Console.WriteLine("\nНажмите Пробел, чтобы вернуться в начальное меню \n Нажмите Backspace, чтобы выйти из программы");
            ConsoleKeyInfo y = Console.ReadKey(true);
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
