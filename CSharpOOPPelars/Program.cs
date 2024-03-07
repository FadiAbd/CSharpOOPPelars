using System.Security.Cryptography.X509Certificates;

namespace CSharpOOPPelars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //instansierat Person och kommit åt variablerna.
            //try
            //{
            //    Person person = new Person();
            //    person.FName = "gdsjdGYDF";
            //    person.LName = "HGDHGDGFUYFUFHGGGHGGG";
            //    person.Age = 1;
            //    Console.WriteLine(person.LName);
            //    Console.WriteLine(person.Age);
            //    Console.WriteLine(person.FName);
            //    Console.WriteLine(person);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"Fel:{ex.Message}");
            //}


            PersonHandler handler = new PersonHandler();
            Person newPerson = handler.CreatePerson(25, "Kalle", "Anka", 180, 80);
            Person newPerson2 = handler.CreatePerson(34, "John", "Doee", 167, 78);
            Person newPerson3 = handler.CreatePerson(56, "Sami", "Smith", 177, 60);
            Console.WriteLine($"Person1 {newPerson}");
            handler.Drive(newPerson.FName, newPerson.LName);
            handler.Study(newPerson.FName, newPerson.LName);
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Person2 {newPerson2}");
            handler.Drive(newPerson2.FName, newPerson2.LName);
            handler.Study(newPerson2.FName, newPerson2.LName);
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Person3 {newPerson3}");
            handler.Drive(newPerson3.FName, newPerson3.LName);
            handler.Study(newPerson3.FName, newPerson3.LName);
            Console.WriteLine();



            List<UserError> Errors = new List<UserError>
            {
                    new NumericInputError(),
                    new TextInputError()
            };

            foreach (var error in Errors)
            {
                Console.WriteLine(error.UEMessage());
            }

            List<IDESystemError> systemErrors = new List<IDESystemError>
            {
                new DebugingSystemError(),
                new UnitTestingSystemError()
            };
            Console.WriteLine();

            foreach (var errors in systemErrors)
            {
                Console.WriteLine(errors.UEMessage());
            }

            Console.WriteLine();

            Dog dog = new Dog();
            dog.DoSound();
            Bird bird = new Bird();
            bird.DoSound();
            Hedgehog hedgehog = new Hedgehog();
            hedgehog.DoSound();
            Worm worm = new Worm ();
            worm.DoSound();
            Wolf wolf = new Wolf ();
            wolf.DoSound();
            Horse horse = new Horse ();
            horse.DoSound();

            var wolfman = new Wolfman ();
            wolfman.Talk();


            Console.ReadKey();

            /*13.F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
            attribut, i vilken klass bör vi lägga det ?

            Svaret : Bird klassen.

            14.F : Om alla djur behöver det nya attributet, vart skulle man lägga det då ? 

            Svaret Animal klassen */


        }
    }
}
