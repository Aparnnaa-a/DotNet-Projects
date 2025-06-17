namespace CalculatorWithFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Value 1 : ");
            a = Int32.Parse(Console.ReadLine());

            Console.Write("Value 2 : ");
            b = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the operator (+,-,*,/) : ");
            string oper = Console.ReadLine();

            if (oper == "+")
            {
                Console.WriteLine("Result : " + Add(a, b));
            }
            else if (oper == "-")
            {
                Console.WriteLine("Result : " + Subtract(a, b));
            }
            else if (oper == "*")
            {
                Console.WriteLine("Result : " + Multiply(a, b));
            }
            else if (oper == "/")
            {
                Console.WriteLine("Result : " + Divide(a, b));
            }
            else
            {
                Console.WriteLine("Invalid operator.");
            }
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }
    
    }
}
