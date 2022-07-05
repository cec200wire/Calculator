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
                Calculate();
                Console.Write("Would you like to do another calculation? [type 'no' to exit] ");
                repeat = Console.ReadLine();
            }
        }
        static void Calculate()
        {
            Console.Write("Please choose an operator [+-*/]: ");
            string op = Console.ReadLine();
            double x = RequestNumber("How many numbers do you want to " + op + "?");
            int count = Convert.ToInt32(x);
            double[] numbers = new double[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = RequestNumber("Please choose a number:");
            }

            double answer = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                switch (op)
                {
                    case "+":
                        answer += numbers[i];
                        break;
                    case "-":
                        answer -= numbers[i];
                        break;
                    case "*":
                        answer *= numbers[i];
                        break;
                    case "/":
                        answer /= numbers[i];
                        break;
                    default:
                        Console.WriteLine("Invalid operator given");
                        break;
                }
            }
            Console.WriteLine("The solution is {0}.", answer);
        }

        static double RequestNumber(string text)
        {
            Console.Write(text + " ");
            string input = Console.ReadLine();
            double n = Double.Parse(input);
            return n;
        }
    }
}    