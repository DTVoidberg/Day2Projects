using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {

        var retry = true;

        while (retry)
        {
            Console.WriteLine("What is your weight in kg?: ");
            string? weight = Console.ReadLine();
            if (int.TryParse(weight, out var weightValue))
                Console.WriteLine($"The weight you have entered is {weightValue} kg");

            Console.WriteLine("What is your height in meters: ");
            string? height = Console.ReadLine();
            if (double.TryParse(height, out double heightValue))
                Console.WriteLine($"The height you have entered is {heightValue} meters");

            double BMI = weightValue / Math.Pow(heightValue, 2);
            Console.WriteLine(BMI);


            Console.WriteLine(BmiCalculator(BMI));

            Console.WriteLine("Do you want to try again? y or n");
            string? userReply = Console.ReadLine();
            if (userReply != "y")
                retry = false;
           
        }

    }
    public static string BmiCalculator(double prompt)
    {
        switch (prompt)
        {
            case >= 30.0:
                return "You are obese";
            case >= 25.0:
                {
                    return "You are Overweight";  
                }

            case >= 18.5:
                {
                    return "You are a healthy weight!";
                }
            default:
               return "Please enter a accurate Weight and Height!";


        }
    }

}


//if (isHealthyWeight)
//{
//    Console.WriteLine($"You have a Healthy Weight of {BMI} BMI");

//}
//else if (isOverweight)
//{
//    Console.WriteLine($"You are Overweight with a BMI of {BMI}");
//}
//else
//    Console.WriteLine($"You are either Underweight or Obese with a BMI of {BMI}");




