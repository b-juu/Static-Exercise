namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = 68.0;
            double celsius = TempConverter.FahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit}°F is equal to {celsius}°C");

            double celsius1 = 34;
            double newFahrenheit = TempConverter.CelsiusToFahrenheit(celsius1);
            Console.WriteLine($"{celsius1}°C is equal to {newFahrenheit}°F");

        }
    }
}
