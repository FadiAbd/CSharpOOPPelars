namespace CSharpOOPPelars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //instansierat Person och kommit åt variablerna.
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


            //PersonHandler handler = new PersonHandler();
            //Person newPerson = handler.CreatePerson(25, "Kalle", "Anka", 180, 80);
            //Person newPerson2 = handler.CreatePerson(34, "John", "Doee", 167, 78);
            //Person newPerson3 = handler.CreatePerson(56, "Sami", "Smith", 177, 60);
            //Console.WriteLine($"Person1 {newPerson}");
            //handler.Drive(newPerson.FName,newPerson.LName);
            //handler.Study(newPerson.FName,newPerson.LName);
            //Console.WriteLine("-------------------------");
            //Console.WriteLine($"Person2 {newPerson2}" );
            //handler.Drive(newPerson2.FName, newPerson2.LName);
            //handler.Study(newPerson2.FName, newPerson2.LName);
            //Console.WriteLine("-------------------------");
            //Console.WriteLine($"Person3 {newPerson3}");
            //handler.Drive(newPerson3.FName, newPerson3.LName);
            //handler.Study(newPerson3.FName, newPerson3.LName);
            //Console.WriteLine();
            


        }
    }
}
