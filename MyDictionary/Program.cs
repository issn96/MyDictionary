using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> students = new MyDictionary<string, string>;
            students.Add("Işınsu Ofelli", "28282828");
            students.Add("Damla Ofelli", "38383838");
            students.Read();
        }
    }
}
