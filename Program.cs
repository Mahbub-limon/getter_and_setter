using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readWrite
{
    class Person 
    {
        public string Name;

        private int age;

        public void SetAge(int age) 
        {
            this.age = age;
        }
    
        public int Getage() 
        {
            return age;
        }

        

    public void DisplayInfo()
        {
            Console.WriteLine($"Name:{Name}");
        }
    
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "limon";
            person.SetAge(23);
            person.Getage();
            person.DisplayInfo();
            Console.WriteLine($"Age:{person.Getage()}");
            
        }
    }
}
