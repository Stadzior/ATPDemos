using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreaded
{
    class Program
    {
        static void Main(string[] args)
        {
            //JumpStart();

            //CancellationTokenSource tokenSource = new CancellationTokenSource();

            //List<int> list = new List<int>();

            //for (int i = 1;i<1000; ++i)
            //{
            //    list.Add(i);
            //}

            //Task<List<double>> powers = Task<List<double>>.Factory.StartNew(() => Compute(list, 2),tokenSource.Token),
            //    powers2 = Task<List<double>>.Factory.StartNew(()=> Compute(list,3),tokenSource.Token);

            //Thread.Sleep(1);

            //while(powers.Status == TaskStatus.Running && powers2.Status == TaskStatus.Running)
            //{
            //    Console.WriteLine("Czekam...");
            //}

            //Console.ReadLine();

            var foos = new List<Foo>
            {
                new Foo { Bar = "A" },
                new Foo { Bar = "B" },
                new Foo { Bar = "C" },
                new Foo { Bar = "D" },
                new Foo { Bar = "E" },
                new Foo { Bar = "F" },
                new Foo { Bar = "G" },
                new Foo { Bar = "H" },
                new Foo { Bar = "I" }
            };

            var fooTasks = new List<Task<string>>();
            foreach (var foo in foos)
                fooTasks.Add(Task.Factory.StartNew(() => LongWorkingThingy(foo.Bar)));

            var results = GetResults(fooTasks).Result;

            Console.WriteLine("-----------------------------------------");
            foreach (var result in results)
                Console.WriteLine(result);
            Console.ReadLine();

        }

        public static async Task<List<string>> GetResults(List<Task<string>> tasks)
        {
            var results = new List<string>();
            while (tasks.Any())
            {
                var finishedTask = await Task.WhenAny(tasks);
                var result = await finishedTask;
                results.Add(result);
                Console.WriteLine(result);
                tasks.Remove(finishedTask);
            }
            return results;
        }

        public static string LongWorkingThingy(string bar)
        {
            Task.Delay(new Random().Next(1, 6) * 500).Wait();
            return bar;
        }

        public static List<double> Compute(List<int> list,int power)
        {
            return list.Select(number => Math.Pow(number, power)).ToList();
        }

        private static void JumpStart()
        {
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Console.WriteLine("Task1");
                }
            });

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Console.WriteLine("Task2");
                }
            });
        }
    }
}
