namespace App;

public static class Program
{
    public static void Main()
    {
        // Excercise1();
        // Excercise2();
        // Excercise3();
        Excercise4();
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
        Loops.Timeout(10);
    }

    public static void Excercise3()
    {
        Van van = new()
        {
            Name = "Ford Transit",
            Year = 1998,
            PassengerCapacity = 8
        };

        van.TurnOn();
        van.OpenSlidingDoor();
        van.DriveToSoccerPractice();
    }

    public static void Excercise4()
    {
        Book book1 = new()
        {
            IsAvailable = false,
            Name = "Lord of the Flies"
        };

        try
        {
            book1.CheckOut("David Garibay");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Have a great day!");
        }

        Book book2 = new()
        {
            IsAvailable = true,
            Name = "The Very Hungry Caterpillar"
        };

        try
        {
            book2.CheckOut("David Garibay");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Have a great day!");
        }

    }
}