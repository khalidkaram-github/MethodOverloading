namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var calculator = new Calculator();
            //Console.WriteLine(calculator.Add(10, 50));
            //Console.WriteLine(calculator.Add(10, 50, 40));

            var infoDisplayer = new InfoDisplayer();


            infoDisplayer.DisplayInfo("Alice", 25); // Calls DisplayInfo(string, int)
            infoDisplayer.DisplayInfo(30, "Bob"); // Calls DisplayInfo(int, string)
            infoDisplayer.DisplayInfo("Charlie"); // Calls DisplayInfo(string)
            infoDisplayer.DisplayInfo(40); // Calls DisplayInfo(int)

        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    public class InfoDisplayer
    {
        public void DisplayInfo(string name, int age)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        public void DisplayInfo(int age, string name)
        {
            Console.WriteLine($"Age: {age}, Name: {name}");
        }

        public void DisplayInfo(string name)
        {
            Console.WriteLine($"Name: {name}");
        }

        public void DisplayInfo(int age)
        {
            Console.WriteLine($"Age: {age}");
        }
    }


}
