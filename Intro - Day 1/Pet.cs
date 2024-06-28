using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro___Day_1
{

    public class Dog
    {
        public string name;

        public string Name
        {
            get
            {
                return $" Pet name is {name}";
            }
            set
            {
                name = value;
            }
        }

        public Dog(string name)
        {
            this.name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine("I'm making a sound");
        }
    }

    public class Cat
    {
        public string newname;
        public string Newname
        {
            get
            {
                return $"Pet New name is {newname}";
            }
            set
            {
                newname = value;
            }
        }
        public Cat(string newname)
        {
            this.newname = newname;
        }
        public void lives()
        {
            Console.WriteLine("I have 9 lives");
        }
    }
}
