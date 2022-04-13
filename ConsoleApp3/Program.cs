using System;


namespace ConsoleApp3
{
    class Program
    {
       static Ilogger Logger { get; set; }
        static void Main(string[] args)
        {
            
            
                Logger = new logger();
                bool a = double.TryParse(Console.ReadLine(), out double firstNum);
                bool b = double.TryParse(Console.ReadLine(), out double SecondNum);
                if (a & b)
                {
                    Isum Sum1 = new Sums(Logger, firstNum, SecondNum);
                    Sum1.Sum();
                }
            else 
            {
                Logger.Error();
                Console.ReadKey();
            }
         
        }

    }
   

}

