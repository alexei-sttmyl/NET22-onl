namespace ClassLibrary1
{
    internal class Person
    {
        public int age;

        public void Greet()
        {
            Console.WriteLine("Guten Abend!!!");
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
    }
}