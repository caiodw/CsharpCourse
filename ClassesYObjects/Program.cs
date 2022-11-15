namespace ClassesYObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sale sale1 = new Sale(100,DateTime.Now);
            Sale sale2 = new Sale(200, DateTime.Now);
            Console.WriteLine(sale1.Getinfo());
            Console.WriteLine(sale2.Getinfo());
        }
    }
    class Sale
    {
        int total;
        DateTime date;

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

        public string Getinfo()
        {
            return total + " " + date.ToLongDateString();
        }

        public void Show()
        {
            Console.WriteLine("Hola soy una venta");
        }
    }
}