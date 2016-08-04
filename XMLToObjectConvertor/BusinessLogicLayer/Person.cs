using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlToObjectConvertor
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person()
        { }

        public Person(int id,string name,string lastName, int age)
        {
            this.ID = id;
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
        }

        public override string ToString()
        {
            return "ID: "+this.ID + ", Name : " + this.Name + ", LastName : " + this.LastName + ", Age : " + this.Age;
        }
    }
}