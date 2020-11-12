using System;

namespace Task6
{
    public class SimpleConsole
    {
        public void Print(string str)
        {
            Console.Write(str);
        }

        public void Pause(bool showMessage)
        {
            if (showMessage)
                Console.Write("\n\nДля продолжения нажмите любую клавишу...");

            Console.ReadKey();
        }
    }
}
