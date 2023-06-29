namespace App
{
    public abstract class Radio
    {
        public string MessageText { get; set; }

        protected Radio(string messageText)
        {
            MessageText = messageText;
        }

        public abstract void SetCommunicationMethod();
        public void SendMessage()
        {
            Console.WriteLine(MessageText);
        }
    }
}