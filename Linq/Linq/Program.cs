using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //JumpStart();
            //SqlLikeDialect();
            //ObjectLikeDialect();
            YieldExample();
            Console.ReadLine();
        }

        private static void YieldExample()
        {
            foreach (var item in Read())
            {
                Console.WriteLine(item);
            }
        }
        
        private static IEnumerable<int> Read()
        {
            foreach(int number in _list)
            {
                Console.WriteLine("A");
                yield return number;
            }
        }

        private static List<int> _list = new List<int>(){ 1, 2, 3, 4, 5 };

        private static void ObjectLikeDialect()
        {
            var generator = new Random();
            List<Person> persons = new List<Person>()
            {
                new Person("Janusz",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
                 new Person("Andrzej",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
                  new Person("Maciej",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
                   new Person("Dominik",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
                    new Person("Tomek",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
                     new Person("Ania",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
                      new Person("Kasia",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
                       new Person("Basia",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
                       new Person("Jakub",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
                       new Person("Jolanta",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
                       new Person("Jarek",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
            };
            //Average persons year, which name starts with "J" and which birth before 2010
            double average = persons.
                Where(person => person.FirstName.StartsWith("J")).
                Where(person => person.BirthDate.Year < 2010).
                Average(person => DateTime.Now.Year - person.BirthDate.Year);

            Console.WriteLine(average);
        }

        private static void JumpStart()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> evenNumbers = from number in list
                                           where number % 2 == 0
                                           select number;

            list.Add(36); // wyświetli również 36 ponieważ IEnumerable na bieżąco ściąga z listy przy wyświetlaniu
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }


            IEnumerable<int> evenNumbers2 = list.Where(x => x % 2 == 0);
            foreach (int number in evenNumbers2)
            {
                Console.WriteLine(number);
            }
        }
        private static void SqlLikeDialect()
        {
            var generator = new Random();
            List<Person> persons = new List<Person>()
            {
                new Person("Janusz",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
                 new Person("Andrzej",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
                  new Person("Maciej",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
                   new Person("Dominik",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
                    new Person("Tomek",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
                     new Person("Ania",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
                      new Person("Kasia",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
                       new Person("Basia",DateTime.Now.AddDays(-generator.Next(100,5000)),90909090),
            };
            IEnumerable<Person> personsBefore2013 = from person in persons
                                                   where person.BirthDate.Year < 2013
                                                   select person;

            DisplayEnumerable(personsBefore2013);
            Console.WriteLine();
            IEnumerable<Person> personsNameStartsWithA = from person in persons
                                                         where person.FirstName.StartsWith("A")
                                                         select person;

            DisplayEnumerable(personsNameStartsWithA);
            Console.WriteLine();
            var personsWithAge = from person in persons
                                 let years = DateTime.Now.Year - person.BirthDate.Year
                                 select new
                                 {
                                     personReference = person,
                                     personYears = years
                                 };

            foreach(var person in personsWithAge)
            {
                Console.WriteLine(person.personReference.FirstName + ", " + person.personReference.BirthDate + ": " + person.personYears);
            }
            Console.WriteLine();

            IEnumerable<Tuple<int, Person>> personsEnum = from person in persons
                                                          let years = DateTime.Now.Year - person.BirthDate.Year
                                                          select new Tuple<int, Person>(years, person);

            foreach (Tuple<int,Person> person in personsEnum)
            {
                Console.WriteLine(person.Item2.FirstName + " " + person.Item2.BirthDate.ToShortDateString());
            }
        }

        private static void DisplayEnumerable(IEnumerable<Person> personsAfter2013)
        {
            foreach (Person person in personsAfter2013)
            {
                Console.WriteLine(person.FirstName + " " + person.BirthDate.ToShortDateString());
            }
        }

    }
}
