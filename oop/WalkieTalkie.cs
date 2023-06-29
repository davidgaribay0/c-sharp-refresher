namespace App
{
    public class WalkieTalkie : Radio
    {
        public WalkieTalkie(string message) : base(message)
        {
        }
        public override void SetCommunicationMethod()
        {
            Console.WriteLine("Communication Method = AM/FM Frequency");
        }
    }
}