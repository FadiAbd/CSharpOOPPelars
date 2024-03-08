using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace CSharpOOPPelars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*instansierat Person och kommit åt variablerna.
             *hanterar undantagen i Program-klassen
             * med en try-catch block
             */

            try
            {
                Person person = new Person();
                person.FName = "gdsjdGYDF";
                person.LName = "HGDHGDGFUYFUFHGGGHGGG";
                person.Age = 1;
                Console.WriteLine(person.LName);
                Console.WriteLine(person.Age);
                Console.WriteLine(person.FName);
                Console.WriteLine(person);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Fel:{ex.Message}");
            }



            // 3. I PersonHandler, skriv en metod som skapar en person med angivna värden
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


            // 3.2) Polymorfism
            List<UserError> Errors = new List<UserError>
            {
                    new NumericInputError(),
                    new TextInputError()
            };
            Console.WriteLine("User errors messages :");
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
            Console.WriteLine("System errors messages :");
            foreach (var errors in systemErrors)
            {
                Console.WriteLine(errors.UEMessage());
            }

            Console.WriteLine();
            Console.WriteLine("Animals sounds :");
            Console.WriteLine("----------------");
            // 3.3) Arv


            Dog dog = new Dog();
            dog.DoSound();
            Bird bird = new Bird();
            bird.DoSound();
            Hedgehog hedgehog = new Hedgehog();
            hedgehog.DoSound();
            Worm worm = new Worm();
            worm.DoSound();
            Wolf wolf = new Wolf();
            wolf.DoSound();
            Horse horse = new Horse();
            horse.DoSound();
            Parrot parrot = new Parrot();
            parrot.DoSound();
            

            // 12. Implementera Talk() som skriver ut vad Wolfman säger.
            var wolfman = new Wolfman();
            wolfman.Talk();
            Console.WriteLine();

            /*13.F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
attribut, i vilken klass bör vi lägga det ?

Svaret : Bird klassen.

14.F : Om alla djur behöver det nya attributet, vart skulle man lägga det då ? 

Svaret: Animal klassen */


            //3.4 Mer Polymorfism
            // Skapar en lista Animals som tar emot djur.
            List<Animal> animals = new List<Animal>();
            Console.WriteLine("Animal List: ");
            Console.WriteLine("------------");
            animals.Add(new Bird { Name = "Birdy", Age = 3, Weight = 0.65, });
            animals.Add(new Dog { Name = "Doggy", Age = 6, Weight = 9 });
            animals.Add(new Horse { Name = "Horsy", Age = 12, Weight = 120 });
            animals.Add(new Hedgehog { Name = "Hoggy", Age = 4, Weight = 5.55 });
            animals.Add(new Wolf { Name = "Wolfy", Age = 7, Weight = 35 });
            animals.Add(new Worm { Name = "Wormy", Age = 1, Weight = 0.11 });
            animals.Add(new Parrot { Name = "Pippi", Age = 4, Weight = 1.7 });

            // Skriver ut samtliga Animals Stats() genom en foreach loop.
            //Gör en check i for-loopen ifall ett djur är också av typen IPerson
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Stats()}");

                //Anropar DoSound();
                animal.DoSound();

                if (animal is IPerson person)
                {
                    Console.WriteLine();
                    // AnropaR Talk() för IPerson
                    person.Talk();
                    Console.WriteLine("I can talk like a person"); 

                }
                else
                {
                    // Om det inte är en IPerson, skrivER ut ett meddelande

                    Console.WriteLine("This animal doesn't talk like a person.");
                    Console.WriteLine();
                }

            }




            // Skapar en Dog Lista
            Console.WriteLine();
            Console.WriteLine("Dog List");
            Console.WriteLine("--------");

            // Skriver ut samtliga Dogs i Stats() genom en foreach loop.
            foreach (var animal in animals)
            {
                if (animal is Dog dog1)
                {
                    Console.WriteLine(dog1.Stats());
                }

            }

            Console.WriteLine();

            /*15. Skapa en ny metod med valfritt namn i klassen Dog som endast returnerar en valfri
               sträng.
           16. Kommer du åt den metoden från Animals listan?

           Svar: Nej, vi kan inte direkt komma åt den nya metoden från animals-listan eftersom             den inte är en del av Animal-klassen.

           17. F: Varför inte?            Svar:  Eftersom GetDogMessage() är en metod som endast finns i Dog-klassen,             kan vi inte anropa den direkt på ett objekt av typen Animal.            18. Hitta ett sätt att skriva ut din nya metod för dog genom en foreach på Animals.            Svar:  Vi kan använda en typkonvertering (cast) för att komma åt den nya metoden för hundar:*/

            Console.WriteLine("Get Dog Message");
            Console.WriteLine("----------------");

            foreach (var animal in animals)
            {
                if (animal is Dog dog3)
                {
                    Console.WriteLine(dog3.GetDogMessage());
                }
            }

            Console.ReadLine();

            //List<Dog> dogs = new List<Dog>();
            //dogs.Add(new Horse {})

            /* 9. F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?

            Svar: Argument: cannot convert from CSharpOOPPelars.Dog to CSharpOOPPelars.Horse.
            Det fungerar inte fast de arver båda från Animal klassen men de är olika typer


            10.F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?

            Svar: Listan måste vara av typen Animal så att alla djur som arver från den klassen 
            kan populera listan

            11. Skriv ut samtliga Animals Stats() genom en foreach loop.
            12. Testa och se så det fungerar.
            13. F: Förklara vad det är som händer.            Svar: Jag har anropat Animals.Stats(); i koden uppe och det fungerade jag fick med alla djur            som ärver av Animal klassen och som har den override metoden stats som implementerar             den abstracta Stats metoden i Animal klassen. */

        }
    }
}
