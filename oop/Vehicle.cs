namespace App
{
    public class Vehicle
    {
        public required string Name { get; set; }
        public required int Year { get; set; }
        public required int PassengerCapacity { get; set; }


        public void TurnOn()
        {
            Console.WriteLine($"Turning on the vehicle {Name}");
        }

        public void TurnOff()
        {
            Console.WriteLine($"Turning on the vehicle {Name}");
        }


    }
}