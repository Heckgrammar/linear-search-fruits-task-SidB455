namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };
            Console.WriteLine("What fruit would you like to find?");
            string userFruit = Console.ReadLine();
            Console.WriteLine(userFruit);
            bool found = false;
            while (found == false) 
            {
                int i = 0;
                if (userFruit == fruits[i])
                {
                    Console.WriteLine($"True - selected fruit is in the array at index {i}");
                    found = true;
                }
                else if (userFruit != fruits[i])
                {
                    i++;
                }
                else if (i == fruits.Length - 1 && userFruit != fruits[i])
                {
                    Console.WriteLine("False - input is not in the array");
                }
            }
        }
    }
}
