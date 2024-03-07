// See https://aka.ms/new-console-template for more information


class TemperatureConverter
{
    static void Main(string[] args)
    {
        bool continueConversion = true;

        while (continueConversion)
        {
            Console.WriteLine("Choose the temperature scale to convert from:");
            Console.WriteLine("1. Celsius");
            Console.WriteLine("2. Fahrenheit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            double temperature;
            string scaleFrom, scaleTo;

            if (choice == 1)
            {
                Console.Write("Enter the temperature in Celsius: ");
                temperature = double.Parse(Console.ReadLine());
                scaleFrom = "Celsius";
                scaleTo = "Fahrenheit";
                Console.WriteLine($"{temperature}°C is equal to {CelsiusToFahrenheit(temperature)}°F.");
            }
            else if (choice == 2)
            {
                Console.Write("Enter the temperature in Fahrenheit: ");
                temperature = double.Parse(Console.ReadLine());
                scaleFrom = "Fahrenheit";
                scaleTo = "Celsius";
                Console.WriteLine($"{temperature}°F is equal to {FahrenheitToCelsius(temperature)}°C.");
            }
            else
            {
                Console.WriteLine("Invalid choice!");
                continue;
            }

            Console.Write("Do you want to convert another temperature? (Y/N): ");
            char response = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            continueConversion = response == 'Y';
        }

        Console.WriteLine("Thank you for using the temperature converter !");
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}

