namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            string repeat = "yes";
            while (repeat != "no")
            {
                Console.Write("Please choose an operator [+-*/]: ");
                string op = Console.ReadLine();
                Console.Write("Please choose a number: ");
                string inputa = Console.ReadLine();
                double firstNo = Double.Parse(inputa);
                Console.Write("Please choose another number: ");
                string inputb = Console.ReadLine();
                double secondNo = Double.Parse(inputb);
                switch (op)
                {
                    case "+":
                        Console.WriteLine("The solution is {0}.", firstNo + secondNo);
                        break;
                    case "-":
                        Console.WriteLine("The solution is {0}.", firstNo - secondNo);
                        break;
                    case "*":
                        Console.WriteLine("The solution is {0}.", firstNo * secondNo);
                        break;
                    case "/":
                        Console.WriteLine("The solution is {0}.", firstNo / secondNo);
                        break;
                    default:
                        Console.WriteLine("Invalid operator given");
                        break;
                }

                Console.Write("Would you like to do another calculation? [yes/no] ");
                repeat = Console.ReadLine();
            }
        }
    }
}    