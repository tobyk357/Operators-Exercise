namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfACircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static void PrintAreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            Double radius = Double.Parse(Console.ReadLine());
            Console.WriteLine($"the area of a circle with a radius of {radius} is {AreaOfACircle(radius)}");
        }
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            
            int sum = a + b;
            int subtract = a - b;
            int mult = a * b;
            
            int quotient = a / b;
            int remainder = a % b;
            
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder} ");
            PrintAreaOfCircle();
        }
    }
}
