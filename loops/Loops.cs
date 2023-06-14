namespace App
{
    public class Loops
    {
        public static void Process(string[] listOfNames)
        {
            foreach (string name in listOfNames)
            {
                SplitName(name);
                ReverseName(name);
            }
        }

        private static void SplitName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write($"{name[i]} ");
            }
            Console.WriteLine("");
        }

        private static void ReverseName(string name)
        {
            List<char> listOfChars = new();
            for (int i = 0; i < name.Length; i++)
            {
                listOfChars.Insert(0, name[i]);
            }
            string reversedName = string.Join("  ", listOfChars);
            Console.WriteLine($"{reversedName} \n");
        }

        public static void Timeout(int timeout = 60)
        {
            int currentTime = 0;

            while (currentTime < timeout)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Processing ...");
                Console.WriteLine($"Elapsed time is {currentTime} seconds");
                currentTime++;

                if (currentTime == timeout)
                {
                    Console.WriteLine($"Process terminated due to timeout of {timeout} seconds");
                }
            }
        }
    }
}