﻿namespace CSharpOOPPelars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // instansierat Person och kommit åt variablerna.
            //try
            //{   
            //    Person person = new Person();
            //    person.FName = "";
            //    person.LName = "HGHGHGHGHGHGHG";
            //    person.Age = 14;
            //    Console.WriteLine(person.LName);
            //    Console.WriteLine(person.Age);
            //    Console.WriteLine(person.FName);
            //    Console.WriteLine(person);
            //}
            //catch (Exception ex)
            //{

            //    //Console.WriteLine("Error");
            //}
            //finally
            //{
            //    Console.WriteLine($"");
            //}
            PersonHandler handler = new PersonHandler();
            Person newPerson = handler.CreatePerson(25, "Kalle", "Anka", 180, 80);
            Person newPerson2 = handler.CreatePerson(34, "John", "Doee", 167, 78);
            Person newPerson3 = handler.CreatePerson(56, "Sami", "Smith", 177, 60);
            //Console.WriteLine($"{newPerson},{newPerson2},{newPerson3}");
            Console.WriteLine(newPerson);
            Console.WriteLine("-------------------------");
            Console.WriteLine(newPerson2 );
            Console.WriteLine("-------------------------");
            Console.WriteLine(newPerson3);


        }
    }
}
