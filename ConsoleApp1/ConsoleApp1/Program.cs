using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            show b1 = new show(1, "xuchengwei");

        }
    }
    class show {
        private int id;
        private String studentclass;
       // Person studentperson;

        public show()
        {
        }
        public show(int _id,String _class)
        {
            this.id = _id;
            this.studentclass = _class;
           // studentperson = _student;
        }

        public Studentshow()
        {
            Console.WindowLeft(id,name)
        }
        public String Studentclass { get => studentclass; set => studentclass = value; }
        public int Id { get => id; set => id = value; }
    }
    class Person
    {
        private String name;
        private bool sex;
        private int age;

        public Person(string name, bool sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }

        public Person()
        {
        }

        public String Name { get => name; set => name = value; }
        public bool Sex { get => sex; set => sex = value; }
        public int Age { get => age; set => age = value; }

        public Person P(Person person)
        {
            return new Person(name, sex, age);
        }
    }

}
