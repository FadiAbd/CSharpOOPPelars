using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpOOPPelars
{
    internal class PersonHandler
    {
        /*2. För att inkapsla Person-objekten ytterligare skall vi skapa klassen
         * PersonHandler -en klass vars syfte är att skapa och hantera dina Person-objekt*/
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        // Constructor who takes parameters and convert double to int
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {

            return new Person(age, fname, lname, (int)height, (int)weight);
        }

        // 4. Fortsätt skapa metoder i PersonHandler för att kunna hantera samtliga
        //    operationer som man kan vilja göra med en Person.

        public void Drive(string fname, string lname)
        {
            string name = fname + " " + lname;
            Console.WriteLine(name + " is driving.");
        }

        public void Study(string fname, string lname)
        {
            string name = fname + " " + lname;
            Console.WriteLine(name + " is studying.");
        }
    }
}


