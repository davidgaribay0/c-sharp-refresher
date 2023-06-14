namespace App
{
    public class Person
    {

        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required DateTime Birthday { get; set; }

        public void SendMessage()
        {
            Console.WriteLine($"Sending a message to: {FirstName} {LastName}\n");
        }

        public void OutputTimeSinceBirth()
        {
            DateTime currentDateTime = DateTime.Now;

            Console.WriteLine($"It is currently {currentDateTime}");
            Console.WriteLine("Calculating time since birth");
            Console.WriteLine("You are currently:\n");

            foreach (TimeMeasurementUnit unit in Enum.GetValues(typeof(TimeMeasurementUnit)))
            {
                CalculateTimeSinceBirth(unit, currentDateTime);
            }
        }

        private void CalculateTimeSinceBirth(TimeMeasurementUnit timeMeasurementUnit, DateTime currentDateTime)
        {
            TimeSpan timeSinceBirth = currentDateTime - Birthday;
            double totalUnits;

            switch (timeMeasurementUnit)
            {
                case TimeMeasurementUnit.Seconds:
                    totalUnits = timeSinceBirth.TotalSeconds;
                    Console.WriteLine($"{totalUnits:N0} seconds old");
                    break;
                case TimeMeasurementUnit.Minutes:
                    totalUnits = timeSinceBirth.TotalMinutes;
                    Console.WriteLine($"{totalUnits:N0} minutes old");
                    break;
                case TimeMeasurementUnit.Hours:
                    totalUnits = timeSinceBirth.TotalHours;
                    Console.WriteLine($"{totalUnits:N0} hours old");
                    break;
                case TimeMeasurementUnit.Days:
                    totalUnits = timeSinceBirth.TotalDays;
                    Console.WriteLine($"{totalUnits:N0} days old");
                    break;
                case TimeMeasurementUnit.Weeks:
                    totalUnits = timeSinceBirth.TotalDays / 365 * 52;
                    Console.WriteLine($"{Math.Round(totalUnits, 2):N0} weeks old");
                    break;
                case TimeMeasurementUnit.Years:
                    totalUnits = timeSinceBirth.TotalDays / 365;
                    Console.WriteLine($"{Math.Round(totalUnits, 2)} years old");
                    break;
                case TimeMeasurementUnit.Decades:
                    totalUnits = timeSinceBirth.TotalDays / 365 / 10;
                    Console.WriteLine($"{Math.Round(totalUnits, 2)} decades old");
                    break;
                default:
                    break;
            }
        }
    }
}
