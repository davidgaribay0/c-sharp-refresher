namespace App;

public static class Program
{
    public static void Main()
    {
        // Excercise1();
        // Excercise2();
        // Excercise3();
        // Excercise4();
        // Excercise5();
        Excercise6();

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

        List<Book> books = new() {
            new Book
            {
                IsAvailable = false,
                Name = "Lord of the Flies"
            },
            new Book
            {
                IsAvailable = true,
                Name = "The Very Hungry Caterpillar"
            }
        };

        foreach (Book book in books)
        {
            try
            {
                book.CheckOut("David Garibay");
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
    public static void Excercise5()
    {
        WalkieTalkie walkieTalkie = new(
            message: "Hello from my walkie Talkie"
        );

        walkieTalkie.SetCommunicationMethod();
        walkieTalkie.SendMessage();
    }

    public static void Excercise6()
    {
        List<object> items = new() {
            "David",
            "Bear",
            "Toby",
            9,
            'A',
            'F',
            'H',
            'D',
            "Hello World",
            9327,
            80,
            20,
            -3,
            122.30,
            -49.0,
            1.0003,
            'c'
        };

        Filter filter = new(items: items);
        var output = filter.GetEventNumbers();

        Console.WriteLine("Input: ");
        foreach (var item in items)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\nOutput: ");

        foreach (var item in output)
        {
            Console.Write(item + " ");
        }
    }

}