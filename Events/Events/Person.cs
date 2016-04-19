using System;

namespace Events
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = Name;
        }

        public void ListenTo(TV tv)
        {
            tv.TurnOn += Tv_TurnOn;
            tv.TurnOff += Tv_TurnOff;
        }

        private void Tv_TurnOn(object sender, string e)
        {
            Console.WriteLine(Name + "Findes out that Tv has turned on.");
        }
        private void Tv_TurnOff(object sender, string e)
        {
            Console.WriteLine(Name + "Findes out that Tv has turned off.");
        }
    }
}
