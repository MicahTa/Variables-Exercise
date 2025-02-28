namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Ozzy";
            int numverOfToys = 60;
            char gender = 'm';
            bool happy = true;
            double age = 2.5;
            decimal netWorth = 0.00m;

            string genderLongHand = (gender == 'm') ? "boy" : "girl";
            Console.WriteLine($"My dogs name is {name} he has {numverOfToys} toys!");
            Console.WriteLine($"{name} is a {genderLongHand} dog");
            Console.WriteLine($"{(gender == 'm' ? "He" : "She")} is {(happy ? "very happy (:" : "a little sad ):")}");
            Console.WriteLine($"{name} is {age} years old!");
            Console.WriteLine($"Unlike me {(gender == 'm' ? "He" : "She")} has ${netWorth} saved up.");

            // I hope you like hearing about my dog he is a very good boy (:
        }
    }
}
