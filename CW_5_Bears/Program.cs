using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CW_5_Bears.bears;

//Logan Walsh
//02-07-2023
//This program is an object adapter example involving bears

namespace CW_5_Bears
{
    class bears
    {
        public class BearAdapter
        {
            bears newBear;
        }
        public interface ToyBear
        {
            void hug();
        }
        public class Teddy
        {
            void hug()
            {
                Console.WriteLine("You hugged the stuffed bear, everything is fine");
            }
        }
            public interface Bear
        {
            void maul();
            void hibernate();
        }
        public class Grizzly
        {
            void maul()
            {
                Console.WriteLine("You have been mauled after hugging the bear");
            }
            void hibernate()
            {
                Console.WriteLine("Evil carpet is tired");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Grizzly angeryBear = new Grizzly();
            Teddy plushBear = new Teddy();

            angeryBear.hibernate();
        }
    }
}
