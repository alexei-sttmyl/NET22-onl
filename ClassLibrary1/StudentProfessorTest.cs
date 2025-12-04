namespace ClassLibrary1
{
    public class StudentProfessorTest
    {
        public void Main()
        {
            Console.WriteLine("\nСоздайте нового человека и заставьте его поздороваться");
            Person NewChelovek = new Person();
            NewChelovek.Greet();

            Console.WriteLine("\nСоздайте новую ученицу, установите возраст, поздоровайтесь и отобразите ее возраст на экране.");
            Student NewUchenitsa = new Student();
            NewUchenitsa.SetAge(68);
            NewUchenitsa.Greet();
            NewUchenitsa.ShowAge();

            Console.WriteLine("\nСоздайте нового Учителя, установите возраст, поздоровайтесь и начните объяснение.");
            Teacher NewTeacher = new Teacher();
            NewTeacher.SetAge(24);
            NewTeacher.Greet();
            NewTeacher.Explain();
        }
    }
}