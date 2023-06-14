namespace App
{

    public class Book
    {

        public required bool IsAvailable { get; set; }
        public required string Name { get; set; }

        public void CheckOut(string personRequestingBook)
        {
            if (this.IsAvailable)
            {
                Console.WriteLine($"Checking out the book {Name} to {personRequestingBook}");
            }
            else
            {
                throw new Exception($"Sorry {personRequestingBook}, the book {Name} is no longer available");
            }
        }
    }
}