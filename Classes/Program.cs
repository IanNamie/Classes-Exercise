namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var honda = new Car();
            honda.Make = "Honda";
            honda.Year = 2017;
            honda.Model = "Civic";

            Console.WriteLine($"I drive a {honda.Make} {honda.Model} it was realeased in {honda.Year}!");
        }
    }
}
