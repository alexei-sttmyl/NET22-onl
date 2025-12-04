namespace ClassLibrary1
{
    internal class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("Im studying");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age: {age} years old");
        }
    }
}