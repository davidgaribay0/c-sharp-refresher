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
    }
}