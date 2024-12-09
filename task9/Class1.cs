using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    public class Person
    {
        public string name;
        public string lastName;
        private int age;

        public void SetAge(int age)
        {
            if (age < 0 || age > 150 )
                    throw new ArgumentException();

            this.age = age;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{name} {lastName}, возраст: {age}");
        }
    }
    
}
