using System;
class Program
{
    static void Main()
    {
        Console.Write("Mời nhập cân nặng :");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Mời nhập chiều cao :");
        double height = Convert.ToDouble(Console.ReadLine());

        double BMI = weight / height * 2;

        if (BMI < 18.5)
        {
            Console.WriteLine("Underweight");
        }
        else if (BMI >= 18.5 && BMI < 25)
        {
            Console.WriteLine("Normal");
        }
        else if (BMI >= 25 && BMI < 30)
        {
            Console.WriteLine("Overweight");
        }
        else if (BMI >= 30)
        {
            Console.WriteLine("Obese");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}
