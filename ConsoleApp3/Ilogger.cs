using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface Ilogger
    {
        void Event(string ad);
        void Error();
    }
    class logger : Ilogger
    {
        public void Error()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            throw new MyException1("Ошибка ввода данных, один из параметров не удалось преобразовать в double");

        }

        public void Event(string ad)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(ad);
        }
    }
    class MyException1 : Exception
    {

        public MyException1(string massege)
        {
            Console.WriteLine(massege);
        }
    }
}
