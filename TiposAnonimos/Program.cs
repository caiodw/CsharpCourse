namespace TiposAnonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hector = new
            {
                Name = "Héctor",
                Country = "Máxico"
            };
            Console.WriteLine($"{hector.Name} {hector.Country}");

            var beers = new[]
            {
                new { Name="Red", Brand = "Delirium"},
                new { Name="London Porter", Brand = "Fullers"}
            };

            foreach (var b in beers)
            {
                Console.WriteLine($"cerveza {b.Name} {b.Brand}");
            }
        }
    }
}