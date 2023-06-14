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
                CalcuateTimeSinceBirth(unit, currentDateTime);
            }
        }

        private void CalcuateTimeSinceBirth(TimeMeasurementUnit timeMeasurementUnit, DateTime currentDateTime)
        {

            switch (timeMeasurementUnit)
            {
                case TimeMeasurementUnit.Seconds:
                    Console.WriteLine($"{(currentDateTime - Birthday).TotalSeconds:N0} seconds old");
                    break;
                case TimeMeasurementUnit.Minutes:
                    Console.WriteLine($"{(currentDateTime - Birthday).TotalMinutes:N0} minutes old");
                    break;
                case TimeMeasurementUnit.Hours:
                    Console.WriteLine($"{(currentDateTime - Birthday).TotalHours:N0} hours old");
                    break;
                case TimeMeasurementUnit.Days:
                    Console.WriteLine($"{(currentDateTime - Birthday).TotalDays:N0} days old");
                    break;
                case TimeMeasurementUnit.Weeks:
                    Console.WriteLine($"{Math.Round((currentDateTime - Birthday).TotalDays / 365 * 52, 2):N0} weeks old");
                    break;
                case TimeMeasurementUnit.Years:
                    Console.WriteLine($"{Math.Round((currentDateTime - Birthday).TotalDays / 365, 2)} years old");
                    break;
                case TimeMeasurementUnit.Decades:
                    Console.WriteLine($"{Math.Round((currentDateTime - Birthday).TotalDays / 365 / 10, 2)} decades old");
                    break;
                default:
                    break;
            }
        }
    }
}
