using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            Person person1 = new Person("Johnny Testowy");
            person1.ListenTo(tv);
            Person person2 = new Person("Mike Mock");
            person2.ListenTo(tv);

            tv.ChangeState();
            tv.ChangeState();

            Console.ReadLine();
        }
    }
}
