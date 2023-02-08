using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Logan Walsh
//02-07-2023
//This program is an object adapter example involving bears

namespace CW_5_Bears
{
    public interface ToyBear
    {
        void hug();
    }
    public class Teddy : ToyBear
    {
        public void hug()
        {
            Console.WriteLine("You hugged the stuffed bear, everything is fine");
        }
    }
    public interface Bear
    {
        void maul();
        void hibernate();
    }
    public class Grizzly : Bear
    {
        public void maul()
        {
            Console.WriteLine("You have been mauled after hugging the evil carpet");
        }
        public void hibernate()
        {
            Console.WriteLine("Evil carpet is tired");
        }
    }
    public class BearAdapter : ToyBear
    {
        Bear newBear;

        public BearAdapter(Bear b)
        {
            newBear = b;
        }
        public void hug()
        {
            newBear.maul();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Grizzly angryBear = new Grizzly();
            Teddy plushBear = new Teddy();
            ToyBear testBear = new BearAdapter(angryBear);

            angryBear.maul();
            angryBear.hibernate();
            plushBear.hug();
            Console.WriteLine();
            testBear.hug();

            Console.ReadKey();
        }
    }
}
