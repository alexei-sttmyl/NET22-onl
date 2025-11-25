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
                "5. List.\n" +
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
                        CreateList();           //Создание, заполнение и управление Списком пользователем. Изменить лист, вывести.
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

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if ((i % 2 == 0) && (matrix[i, j] % 2 == 0))        //отсчёт с нуля - в нулевой строке выводятся чётные числа
                        {
                            Console.Write($"{matrix[i, j]} ");
                        }
                        else if ((i % 2 != 0) && (matrix[i, j] % 2 != 0))
                        {
                            Console.Write($"{matrix[i, j]} ");
                        }
                    }
                    Console.WriteLine();
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

    //Листы
    public static void CreateList()
    {
        Console.WriteLine("You have selected Creation List, filling it and managing it\n");

        List<int> UserList = new List<int>();
        var rand = new Random();
        bool isUserControlRunning = true;

        Console.WriteLine("Your List: \n");
        for (int i = 0; i < 10; i++)                    //Заполнение и вывод листа
        {
            UserList.Add(rand.Next(1, 21));
            Console.Write($"[{i}]: {UserList[i]}\n");
        }

        while (isUserControlRunning)                    // Предоставление пользователю возможности управления Списком
        {
            Console.WriteLine("\nChoose the operation:\n" +
                "1. Print\n" +
                "2. Add\n" +
                "3. Remove\n" +
                "4. Console Clear\n" +
                "0. Exit");

            string? operationWithList = Console.ReadLine();

            switch (operationWithList)
            {
                case "1":                   //Вывод на консоль всего списка
                    {
                        Console.WriteLine("Your List: \n");
                        for (int i = 0; i < UserList.Count; i++)
                        {
                            Console.Write($"[{i}]: {UserList[i]}\n");
                        }
                        break;
                    }

                case "2":                   //Добавление элемента в конец списка
                    {
                        int newElement = 0;
                        Console.WriteLine("Enter an integer to add:");
                        if (int.TryParse(Console.ReadLine(), out newElement))
                        {
                            UserList.Add(newElement);
                        }
                        break;
                    }

                case "3":                   //Удаление элемента из списка по индексу
                    {
                        int indexToDelete = 0;
                        Console.WriteLine("Enter an integer to add:");
                        if (int.TryParse(Console.ReadLine(), out indexToDelete) && indexToDelete > 0 && indexToDelete < UserList.Count)
                        {
                            UserList.RemoveAt(indexToDelete);
                        }
                        else
                        {
                            Console.WriteLine("Try again");
                        }
                        break;
                    }

                case "4":                   //Очистить консоль
                    {
                        Console.Clear();
                        break;
                    }

                case "0":                   //Выход
                    {
                        isUserControlRunning = false;
                        break;
                    }

                default:
                    Console.WriteLine("Try again");
                    break;
            }
        }

        Console.WriteLine("New List: \n");

        for (int i = 0; i < UserList.Count; i++)
        {

            if (i % 2 == 0)
            {
                UserList.RemoveAt(i);
                UserList.Insert(i, UserList[i] * 2);
            }
            else
            {
                UserList.RemoveAt(i);
                UserList.Insert(i, 0);
            }
            Console.Write($"[{i}]: {UserList[i]}\n");
        }
    }
}