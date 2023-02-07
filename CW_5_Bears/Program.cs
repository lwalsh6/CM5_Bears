using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_5_Bears
{
    class bears
    {
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
            public class BearAdapter
            {
                //Needs adaptee variable
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
