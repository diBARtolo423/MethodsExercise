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
            int x = 2;
            int y = 3;
            Console.WriteLine(Add(x, y));
            Console.WriteLine(Sub(x, y));
            Console.WriteLine(Div(x, y));
            Console.WriteLine(Mult(x, y));

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

            var story = $"Hello! My name is {name}. {color} is my favorite color, {animal} are my favorite animal, and {band} is my favorite band.";
            return story;
           
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            return x - y;
        }
        public static int Div(int x, int y)
        {
            return x / y;
        }
        public static int Mult(int x, int y)
        {
            return x * y;
        }


    }

 
}
