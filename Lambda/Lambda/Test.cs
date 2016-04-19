using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Test
    {
        public delegate void Print(string str);
        public delegate void PrintNoParam();
        //public delegate void Calculate(float x, float y);

        public void TestMethod()
        {
            Print printFunction = Print1;
            printFunction += Print2;
            string value = "Heheszki";
            printFunction(value);

            printFunction = (str) => Console.WriteLine("lambda: " + str);
            printFunction(value);

            //Calculate calculateFunction = (x, y) => Console.WriteLine(x + y);
            //calculateFunction += (x, y) => Console.WriteLine(x - y);
            //calculateFunction += (x, y) => Console.WriteLine(x * y);
            //calculateFunction += (x, y) => Console.WriteLine(x / y);
            //calculateFunction(2.0f, 3.0f);

            Action<string> calculateAction = Print1;
            calculateAction += Print2;
            calculateAction("eeeeeeeeee");
            calculateAction = x => Console.WriteLine(x + "hehehehhee");
            calculateAction("eeeeeeeeee");

            Predicate<string> nullCheck = str => str == null;
            Console.WriteLine(nullCheck("hehe"));
            Console.WriteLine(nullCheck(null));

            Console.WriteLine(Calculate(2.0f, 3.0f, (x, y) => x + y));

        }

        public float Calculate(float x,float y,Func<float,float,float> calculateFunction)
        {
            return calculateFunction(x, y);
        }

        public void Print1(string str)
        {
            Console.WriteLine("Print1: " + str);
        }
        public void Print2(string str)
        {
            Console.WriteLine("Print2: " + str);
        }
    }
}
