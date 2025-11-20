internal class Program
{
    private static void Main(string[] args)
    {
        double result, firstNumber, secondNumber;
        string? firstInput, secondInput;

        Console.WriteLine("Vecher v hatu");

        while (true)
        {
            Console.WriteLine("Choose the operation:\n" +
                "1. +\n" +
                "2. -\n" +
                "3. /\n" +
                "4. *\n" +
                "5. %\n" +
                "6. √\n" +
                "7. Exit\n");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("You have chosen addition\n");

                    Console.Write("Enter your first number: ");
                    firstInput = Console.ReadLine();
                    Console.Write("Enter your second number: ");
                    secondInput = Console.ReadLine();

                    if (Double.TryParse(firstInput, out firstNumber) && Double.TryParse(secondInput, out secondNumber))
                    {
                        Console.Clear();
                        result = firstNumber + secondNumber;
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {result}\n\n");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Try again, I believe in you\n\n");
                        break;
                    }

                case "2":
                    Console.WriteLine("You have chosen subtraction\n");

                    Console.Write("Enter your first number: ");
                    firstInput = Console.ReadLine();
                    Console.Write("Enter your second number: ");
                    secondInput = Console.ReadLine();


                    if (Double.TryParse(firstInput, out firstNumber) && Double.TryParse(secondInput, out secondNumber))
                    {
                        Console.Clear();
                        result = firstNumber - secondNumber;
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {result} \n\n");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Try again, I believe in you\n\n");
                        break;
                    }

                case "3":
                    Console.WriteLine("You have chosen division\n");

                    Console.Write("Enter your first number: ");
                    firstInput = Console.ReadLine();
                    Console.Write("Enter your second number: ");
                    secondInput = Console.ReadLine();


                    if (Double.TryParse(firstInput, out firstNumber) && Double.TryParse(secondInput, out secondNumber))
                    {
                        Console.Clear();
                        result = firstNumber / secondNumber;
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Try again, I believe in you\n\n");
                        break;
                    }

                case "4":
                    Console.WriteLine("You have chosen multiplication\n");

                    Console.Write("Enter your first number: ");
                    firstInput = Console.ReadLine();
                    Console.Write("Enter your second number: ");
                    secondInput = Console.ReadLine();


                    if (Double.TryParse(firstInput, out firstNumber) && Double.TryParse(secondInput, out secondNumber))
                    {
                        Console.Clear();
                        result = firstNumber * secondNumber;
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {result} \n\n");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Try again, I believe in you\n\n");
                        break;
                    }

                case "5":
                    Console.WriteLine("You have chosen remainder\n");

                    Console.Write("Enter your first number: ");
                    firstInput = Console.ReadLine();
                    Console.Write("Enter your second number: ");
                    secondInput = Console.ReadLine();


                    if (Double.TryParse(firstInput, out firstNumber) && Double.TryParse(secondInput, out secondNumber))
                    {
                        Console.Clear();
                        result = firstNumber % secondNumber;
                        Console.WriteLine($"{firstNumber} % {secondNumber} = {result}\n\n");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Try again, I believe in you\n\n");
                        break;
                    }

                case "6":
                    Console.WriteLine("You have chosen square root\n");

                    Console.Write("Enter your first number: ");
                    firstInput = Console.ReadLine();

                    if (Double.TryParse(firstInput, out firstNumber))
                    {
                        Console.Clear();
                        result = Math.Sqrt(firstNumber);
                        Console.WriteLine($"√{firstNumber}  = {result}\n\n");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Try again, I believe in you\n\n");
                        break;
                    }

                case "7":
                    Console.Clear();
                    Console.WriteLine("Good bye, bitches");
                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Try again, I believe in you\n\n");
                    break;
            }
        }
    }
}