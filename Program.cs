namespace App;

public static class Program
{
    public static void Main()
    {
        Person person = new()
        {
            FirstName = "David",
            LastName = "Garibay"
        };
        person.SendMessage();
    }
}