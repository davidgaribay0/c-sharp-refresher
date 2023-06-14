namespace App;

public static class Program
{
    public static void Main()
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
}