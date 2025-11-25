internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Operations: \n" +
                "1. From N to 1\n" +
                "2. Sequence +N N-times\n" +
                "3. Fibonacci Sequence\n" +
                "4. Create user sized matrix. Fill it. Print. \n" +
                "Search positive and negaative numbers.\n" +
                "5. Print matrix V2.0.\n" +
                "Count the numbers of every unique number.\n" +
                "6. Create List\n" +
                "7. Change or print List elements\n" +
                "8. Print List. Change List. Print List. Create HeshSet\n" +
                "0. Exit\n\n" +
                "Choose the operation: ");
            string? selectedOperation = Console.ReadLine();

            switch (selectedOperation)
            {
                case "1":
                    {
                        CreateSequenceFromN(); //Вызов метода, который выводит последовательность от N до 1
                        break;
                    }
                case "2":
                    {
                        CreateSequenceNTimes(); //Вызов метода, который выводит последовательность из N чисел,
                        break;                  //где каждое следующее на N больше предыдущего

                    }
                case "3":
                    {
                        CreateFibonacciSequence(); //Вызов метода, который выводит N первых чисел из последовательности Фибоначчи
                        break;
                    }
                case "4":
                    {
                        CreateFillPrintMatrix(); //Создание матрицы по размерам пользователя, заполнение рандомом, оформленный вывод на консоль,
                        break;                   //подсчёт положительных и отрицательных значений, подсчёт словарём количества каждого числа в матрице

                    }
                case "5":
                    {

                        break;
                    }
                case "0":
                    {
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("ERROR! \nTry again");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }


    //Циклы:
    public static void CreateSequenceFromN()
    {
        Console.WriteLine("You have selected Sequence from N\n" +
            "Enter your N: ");
        string? inputN = Console.ReadLine();
        int N = 0;
        if (int.TryParse(inputN, out N))
        {
            if (N > 1)
            {
                Console.WriteLine("\nSequence: ");
                for (int i = N; i >= 1; i--)
                {
                    Console.Write($"{i} ");
                }
            }
            else if (N < 1)
            {
                Console.WriteLine("\nSequence: ");
                for (int i = N; i <= 1; i++)
                {
                    Console.Write($"{i} ");
                }
            }
            else
            {
                Console.WriteLine("\nSequence: \n1");
            }
        }
        else
        {
            Console.WriteLine("Try again!");
        }
    }

    public static void CreateSequenceNTimes()
    {
        Console.WriteLine("You have selected Sequence N times\n" +
           "Enter your N (less than 1000): ");
        string? inputN = Console.ReadLine();
        int N = 0;
        if (int.TryParse(inputN, out N))
        {
            if (N < 1000)
            {
                int current = 0;
                Console.Write($"Sequence: \n{current} ");

                for (int i = 1; i <= N; i++)
                {
                    current += N;
                    Console.Write($"{current} ");
                }
            }
            else
            {
                Console.WriteLine("LESS THEN 1000, PLEASE. Try again.");
            }
        }
    }

    public static void CreateFibonacciSequence()
    {
        Console.WriteLine("You have selected Fibonacci Sequence\n" +
           "Enter your N (less than 1000): ");
        string? inputN = Console.ReadLine();
        int N = 0;
        if (int.TryParse(inputN, out N))
        {
            if (N < 1000)
            {
                Queue<int> FibonacciLast2 = new Queue<int>(2);
                FibonacciLast2.Enqueue(0);
                Console.Write($"Fibonacci Sequence: \n ");
                Console.Write($"{FibonacciLast2.Peek()} ");
                FibonacciLast2.Enqueue(1);

                for (int i = 1; i < N; i++)
                {
                    FibonacciLast2.Enqueue(FibonacciLast2.Dequeue() + FibonacciLast2.Peek());
                    Console.Write($"{FibonacciLast2.Peek()} ");
                }
            }
            else
            {
                Console.WriteLine("LESS THEN 1000, PLEASE. Try again.");
            }
        }
    }

    //Массивы
    public static void CreateFillPrintMatrix()
    {
        Console.WriteLine("You have selected Creation matrix, fill it, print,\n" +
            "search positive and negative and count of every number\n" +
           "Enter size of your matrix (from 1 to 6): ");
        string? inputN = Console.ReadLine();
        int N = 0;
        if (int.TryParse(inputN, out N))
        {
            if (N >= 1 && N <= 6)
            {
                var rand = new Random();
                int[,] matrix = new int[N, N];
                int positive = 0, negative = 0;
                var CountOfNumber = new Dictionary<int, int>();

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        matrix[i, j] = rand.Next(-9, 10);
                        Console.Write($"{matrix[i, j]}  ");
                        if (matrix[i, j] >= 0)
                        {
                            positive++;
                        }
                        else
                        {
                            negative++;
                        }
                    }
                    Console.WriteLine();
                }


                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {

                        if (CountOfNumber.ContainsKey(matrix[i, j]))
                        {
                            CountOfNumber[matrix[i, j]]++;
                        }
                        else
                        {
                            CountOfNumber[matrix[i, j]] = 1;
                        }

                    }
                }

                Console.WriteLine($"\nCount of positive: {positive}\n" +
                    $"Count of negative: {negative}\n");

                foreach (var number in CountOfNumber)
                {
                    Console.WriteLine($"Number: {number.Key}, Count: {number.Value}");
                }
            }
            else
            {
                Console.WriteLine("FROM 1 TO 6 PLEASE!!! Try again.");
            }
        }
        else
        {
            Console.WriteLine("It's not an integer");
        }
    }
}