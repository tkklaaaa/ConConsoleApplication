namespace ConsoleHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string? flag = "";
            while (flag != "Q")
            {
                string? name = "";
                string? sex = "";
                string? height = "";

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("----------------++++----------------");
                Console.WriteLine("Hello, World!");
                Console.WriteLine();
                while (name == "" || name == null || name == " " || name.Any(char.IsDigit) || name.Length < 2)
                {
                    Console.Write("Please, enter your name (eng): ");
                    name = Console.ReadLine();

                    if (name == "" || name == null || name == " " || name.Any(char.IsDigit) || name.Length < 2)
                    {
                        Console.WriteLine("Name cannot be empty. Please try again.");
                    }
                }

                Console.WriteLine("\n Welcome to C# Programming, " + name + "!\n");

                while (sex != "M" && sex != "F")
                {
                    Console.Write("Please, enter your sex (M/F): ");
                    sex = Console.ReadLine()?.ToUpper();
                    if (sex != "M" && sex != "F")
                    {
                        Console.WriteLine("Sex must be 'M' or 'F'. Please try again.");
                    }
                }

                while (height == "" || height == null || height == " " || !height.All(char.IsDigit))
                {
                    Console.Write("Please, enter your height (cm): ");
                    height = Console.ReadLine();
                    if (height == "" || height == null || height == " " || !height.All(char.IsDigit))
                    {
                        Console.WriteLine("Height must be a number. Please try again.");
                    }
                }
                int weight = 0;
                if (sex == "M")
                {
                    weight = Convert.ToInt16(height) - 100;
                }
                else
                {
                    weight = Convert.ToInt16(height) - 110;
                }
                Console.WriteLine("Your Ideal Weight is " + weight + " kg.");
                Console.WriteLine("----------------++++----------------");
                Console.Write("Press Q to quit or any other key to continue: ");
                flag = Console.ReadLine()?.ToUpper();
            }
            static void line(string ch, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
        }
    }

}
