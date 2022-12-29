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
            Console.WriteLine(Add(4, 8));
            Console.WriteLine(Sub(10, 5));
            Console.WriteLine(Div(15, 3));
            Console.WriteLine(Mult(6, 2));

            // Challange


        }

        //Exercise 1

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

        //Exercise 2

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

        //Challange

        //public static int Add(params int[] nums)
        //{
        //    int sum = 0;
        //    foreach (int num in nums)
        //    {
        //        sum += num;
        //    }
        //    return sum;
        //}

    }

 
}
