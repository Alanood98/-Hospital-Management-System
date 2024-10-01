using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class person
    {
        public string Name;
        public int Age;

        public enum Gender { Male, Female, Other }
        public Gender g;

        public person(string name, int age, Gender gender)
        {
            Name = name;
            Age = age;
            g = gender;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("The name of person is:" + Name);
            Console.WriteLine("The age of person is:" + Age);
            Console.WriteLine("The gender is :" + g);
        }
    }
}







