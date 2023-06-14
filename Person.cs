namespace App
{
    public class Person
    {

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required DateTime Birthday { get; set; }

        public void SendMessage()
        {
            Console.WriteLine($"Sending a message to: {FirstName} {LastName}");
        }

        public void CalcuateTimeSinceBirth(TimeMeasurementUnit timeMeasurementUnit)
        {
            DateTime currentDateTime = DateTime.Now;

            switch (timeMeasurementUnit)
            {
                case TimeMeasurementUnit.Seconds:
                    Console.WriteLine($"You are {(currentDateTime - Birthday).TotalSeconds:N0} seconds old");
                    break;
                case TimeMeasurementUnit.Minutes:
                    Console.WriteLine($"You are {(currentDateTime - Birthday).TotalMinutes:N0} minutes old");
                    break;
                case TimeMeasurementUnit.Hours:
                    Console.WriteLine($"You are {(currentDateTime - Birthday).TotalHours:N0} hours old");
                    break;
                case TimeMeasurementUnit.Days:
                    Console.WriteLine($"You are {(currentDateTime - Birthday).TotalDays:N0} days old");
                    break;
                case TimeMeasurementUnit.Weeks:
                    Console.WriteLine($"You are {Math.Round((currentDateTime - Birthday).TotalDays / 365 * 52, 2):N0} weeks old");
                    break;
                case TimeMeasurementUnit.Years:
                    Console.WriteLine($"You are {Math.Round((currentDateTime - Birthday).TotalDays / 365, 2)} years old");
                    break;
                case TimeMeasurementUnit.Decades:
                    Console.WriteLine($"You are {Math.Round((currentDateTime - Birthday).TotalDays / 365 / 10, 2)} decades old");
                    break;
                default:
                    break;
            }
        }
    }
}
