namespace App { }

public class Person
{

    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public void SendMessage()
    {
        Console.WriteLine($"Sending a message to: {FirstName} {LastName}");
    }
}