using System;


namespace AssignmentQuiz1
{
    class Person
    {
        public string Name { get; set; }
        public int Weight { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            bool addingPeople = true;

            while (addingPeople)
            {
                Console.WriteLine("Enter the name of the person (or type 'done' to finish adding people):");
                string name = Console.ReadLine();

                if (name.ToLower() == "done")
                {
                    addingPeople = false;
                    break;
                }

                Console.WriteLine("Enter the weight of the person:");
                int weight = int.Parse(Console.ReadLine());

                people.Add(new Person { Name = name, Weight = weight });
            }

            Console.WriteLine("\nList of People:");
            int totalWeight = 0;
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Weight: {person.Weight}");
                totalWeight += person.Weight;
            }

            Console.WriteLine($"\nTotal Weight of all people: {totalWeight}");

            Console.ReadLine(); // to prevent the console from closing immediately
        }
    }
}
