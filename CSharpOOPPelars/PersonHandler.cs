using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPPelars
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
           pers.Age = age;
        }
        // Constructor who takes parameters and convert double to int
        public Person CreatePerson(int age,string fname,string lname, double height, double weight)
        {

            return new Person(age,fname,lname,(int)height,(int)weight);
        }
    }
}
        

