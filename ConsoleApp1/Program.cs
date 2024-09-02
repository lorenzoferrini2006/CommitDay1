namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // square
            Console.WriteLine("Square:");
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5) + "\n");

            Console.WriteLine("Array square:");
            int[] numbers = { 1, 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => square(x));
            Console.WriteLine(string.Join(" ", squaredNumbers) + "\n");

            // square root
            Console.WriteLine("Square root:");
            Func<int, double> squareroot = x => Math.Sqrt(x);
            Console.WriteLine(squareroot(4) + "\n");

            // cube
            Console.WriteLine("Cube:");
            Func<int, int> cube = x => x * x * x;
            Console.WriteLine(cube(5) + "\n");

            Console.WriteLine("Array cube:");
            var cubedNumbers = numbers.Select(x => cube(x));
            Console.WriteLine(string.Join(" ", cubedNumbers) + "\n");

            // addition
            Console.WriteLine("Addition:");
            Func<int, int, int> addition = (x, y) => (x + y);
            Console.WriteLine(addition(20, 5) + "\n");

            // subtraction
            Console.WriteLine("Subtraction:");
            Func<int, int, int> subtraction = (x, y) => (x - y);
            Console.WriteLine(subtraction(20, 5) + "\n");

            // multiplication
            Console.WriteLine("Multiplication:");
            Func<int, int, int> multiplication = (x, y) => (x * y);
            Console.WriteLine(multiplication(20, 5) + "\n");

            // division
            Console.WriteLine("Division:");
            Func<int, int, double> division = (x, y) => (x / y);
            Console.WriteLine(division(20, 5) + "\n");

            // increment
            Console.WriteLine("Increment:");
            var IncrementBy = (int source, int increment = 1) => source + increment;
            Console.WriteLine("5 + 1 = " + IncrementBy(5));
            Console.WriteLine("5 + 3 = " + IncrementBy(5, 3) + "\n");

            // tuple
            Console.WriteLine("Triple multiplication:");
            Func<(int, int, int), int> multiplication3 = x => x.Item1 * x.Item2 * x.Item3;
            Console.WriteLine(multiplication3((3, 4, 5)) + "\n");

            // bool return
            Func<int, bool> equalsTo5 = x => x == 5;
            Console.WriteLine("5 = 5? " + equalsTo5(5));
            Console.WriteLine("953163409 = 5? " + equalsTo5(953163409) + "\n");

            // count odd numbers
            Console.WriteLine("Odd numbers: ");
            int[] numbers2 = { 6, 0, 8, 4, 2, 5, 6, 1, 2, 9 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);
            Console.WriteLine($"There are {oddNumbers} odd numbers in {string.Join(" ", numbers2)}");

            // search item in a list
            var stringSet = new List<string>
            {
                "toy story", "the pianist", "finding nemo", "despicable me", "sao",
                "cars", "pinocchio", "men in black", "frozen" , "rapunzel" ,"oceania",
                "the rookie", "suits", "loser"
            };

            var setsWithManyPositives =
                from aString in stringSet
                where aString[0] >= 'l'
                select aString;

            foreach(string a in  setsWithManyPositives) {  Console.WriteLine(a); }
        }
    }
}