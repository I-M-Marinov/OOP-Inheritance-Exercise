using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
            Add(age,name);
        }

        public override void Add(int age, string name)
        {
            if (age > 0 && age <= 15)
            {
                Name = name;
                Age = age;
            }
        }
    }
}
