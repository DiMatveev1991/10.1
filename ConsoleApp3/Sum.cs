using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
          public interface Isum
        {
            public void Sum();

        }
        public class Sums : Isum
        {
           private readonly double a;
           private readonly double b;
           Ilogger logger { get;  }
            public Sums(Ilogger logger, double a, double b)
            {
                this.a = a;
                this.b = b;
                this.logger = logger;
            }
            void Isum.Sum()
            {
            double ab = a + b;
            string ad = Convert.ToString(ab);
            
            logger.Event(ad);
            }
        }
}
