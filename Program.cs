using ClassLibL5;

internal class Program
{
    private static void Main(string[] args)
    {
        //string text = "Wow! This is my 1st tsest. Do you see number42? Yes! \r\n" +
        //    "Otto ran to room101. Anna loves level999. \r\n" +
        //    "Are you ready? No, I am not! \r\n" +
        //    "This sentence has no comma. But this one, definitely has a comma, right? \r\n" +
        //    "Hey! Look at Bob — he found 777 coins! \r\n" +
        //    "Is 12345 the longest digit-word? Maybe! \r\n" +
        //    "Otto said: \"Wow!\" Anna replied: \"Yes!\" \r\n" +
        //    "Final test. Done!\n";

        string text = "Wow! This is my 1st tsest. Do you see number42? Yes! " +
            "Otto ran to room101. Anna loves level999. " +
            "Are you ready? No, I am not! " +
            "This sentence has no comma. But this one, definitely has a comma, right? " +
            "Hey! Look at Bob — he found 777 coins! " +
            "Is 12345 the longest digit-word? Maybe! " +
            "Otto said: \"Wow!\" Anna replied: \"Yes!\" " +
            "Final test. Done!";

        ITextAnalyzer textAnalyzer = new TextAnalyzer();
        //textAnalyzer.GetWordsWithNumbers(text);
        //textAnalyzer.LongestWordAAndCount(text);
        //textAnalyzer.ReplaceValueFromDigitToLetter(text);

        bool isContinueProgram = true;

        while (isContinueProgram)
        {
            Console.Clear();
            Console.WriteLine($"Our text: \n\n{text}\n");
            Console.WriteLine("Operations: \n" +
                "1. GetWordsWithNumbers\n" +
                "2. LongestWordAAndCount\n" +
                "3. ReplaceValueFromDigitToLetter\n" +
                "4. GetWordsWithSameCharStartEnd\n" +
                "5. PrintPalindrome\n" +
                "6. PrintInterrogativeThenExclamatory\n" +
                "0. Exit");

            Console.Write("Choose the operation: ");
            string? chosenOperation = Console.ReadLine();
            Console.WriteLine();

            switch (chosenOperation)
            {
                case "1":
                    {
                        textAnalyzer.GetWordsWithNumbers(text);     //+ Найти слова, содержащие максимальное количество цифр.
                        Console.ReadKey();
                        break;
                    }
                case "2":
                    {
                        textAnalyzer.LongestWordAAndCount(text);    //+ Найти самое длинное слово и определить, сколько раз оно встретилось в тексте.
                        Console.ReadKey();
                        break;
                    }
                case "3":
                    {
                        textAnalyzer.ReplaceValueFromDigitToLetter(text);   //+ Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять».
                        Console.ReadKey();
                        break;
                    }
                case "4":
                    {
                        textAnalyzer.GetWordsWithSameCharStartEnd(text);     //+ Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.
                        Console.ReadKey();
                        break;
                    }
                case "5":
                    {
                        textAnalyzer.PrintPalindrome(text);      //+ Вывести палиндромы, если они есть.
                        Console.ReadKey();
                        break;
                    }
                case "6":
                    {
                        textAnalyzer.PrintInterrogativeThenExclamatory(text);          //TODO
                        Console.ReadKey();
                        break;
                    }
                //case "7":                                                    //TODO
                //    {
                //        textAnalyzer.PrintSentencesWithoutCommas(text);
                //        Console.ReadKey();
                //        break;
                //    }
                //case "8":                                                    //TODO 
                //    {
                //        textAnalyzer.SearchByPartOfInput(text);
                //        Console.ReadKey();
                //        break;
                //    }
                case "0":
                    {
                        isContinueProgram = false;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong chosen operation \nTry Again");
                        Console.ReadKey();
                        break;
                    }
            }
        }
    }

}