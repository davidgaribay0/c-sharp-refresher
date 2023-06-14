namespace App;

public static class Program
{
    public static void Main()
    {
        // Excercise1();
        Excercise2();
    }

    public static void Excercise1()
    {
        Person person = new()
        {
            FirstName = "David",
            LastName = "Garibay",
            Birthday = new DateTime(1995, 7, 12, 0, 0, 0)
        };
        person.SendMessage();
        person.OutputTimeSinceBirth();
    }

    public static void Excercise2()
    {
        string[] names = new string[] { "David", "Mario", "Alejandro", "Anthony", "Rick", "Peter" };
        Loops.Process(names);
    }
}