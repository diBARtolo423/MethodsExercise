namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            var myStory = Story();
            Console.WriteLine(myStory);

            // Exercise 2

        }
        public static string Story()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine();

            var story = $"Hello! My name is {name}. {color} is my favorite color, {animal} is my favorite animal, and {band} is my favorite band.";
            return story;
           
        }


    }

 
}
