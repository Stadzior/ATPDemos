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

            CancellationTokenSource tokenSource = new CancellationTokenSource();
            
            List<int> list = new List<int>();

            for (int i = 1;i<1000; ++i)
            {
                list.Add(i);
            }

            Task<List<double>> powers = Task<List<double>>.Factory.StartNew(() => Compute(list, 2),tokenSource.Token),
                powers2 = Task<List<double>>.Factory.StartNew(()=> Compute(list,3),tokenSource.Token);

            Thread.Sleep(1);

            while(powers.Status == TaskStatus.Running && powers2.Status == TaskStatus.Running)
            {
                Console.WriteLine("Czekam...");
            }

            Console.ReadLine();
        }

        static List<double> Compute(List<int> list,int power)
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
