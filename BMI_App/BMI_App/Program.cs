namespace BMI_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BMI Calculator";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== BMI Calculator ===\n");
            Console.ResetColor();

            // เพศ
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Select your gender:");
            Console.WriteLine("1. Male");
            Console.WriteLine("2. Female");
            Console.ResetColor();
            Console.Write("Enter number (1 or 2): ");

            int gender = int.Parse(Console.ReadLine());
            string genderText = (gender == 1) ? "Male" : "Female";

            Console.WriteLine();

            // น้ำหนัก
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your weight (kg): ");
            Console.ResetColor();
            double weight = double.Parse(Console.ReadLine());

            // ส่วนสูง   
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your height (cm): ");
            Console.ResetColor();
            double heightCm = double.Parse(Console.ReadLine());
            double heightM = heightCm / 100;

            // คำนวน BMI
            double bmi = weight / (heightM * heightM);

            // Output
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nYour Gender: {genderText}");
            Console.WriteLine($"Your BMI is: {bmi:F2}");
            Console.ResetColor();

            // คำนวนแยกเพศ
            string result;

            if (gender == 1) // ช
            {
                if (bmi < 18.5) result = "Underweight";
                else if (bmi < 25) result = "Normal weight";
                else if (bmi < 30) result = "Overweight";
                else result = "Obesity";
            }
            else if (gender == 2); // ญ
            {
                if (bmi < 18.0) result = "Underweight";
                else if (bmi < 24) result = "Normal weight";
                else if (bmi < 29) result = "Overweight";
                else result = "Obesity";
            }

            // ผลลัพธ์
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nInterpretation: " + result);
            Console.ResetColor();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

