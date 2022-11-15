namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[6]
            {
                "Pancho",
                "Paco",
                "Ana",
                "Ruben",
                "Karla",
                "Luis"
            };

            bool run = false;
            for (int i = 0; i< friends.Length; i++)
            {
                Console.WriteLine(friends[i]);
            }
        }
    }
}