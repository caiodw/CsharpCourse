using System.IO;
namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@".\pato.txt");
                Console.WriteLine(content);

                //string content2 = File.ReadAllText(@"C:\Users\horac\source\repos\Variables\Excepciones\bin\Debug\net6.0\pato2.txt");
                //Console.WriteLine(content2);

                throw new Exception("Ocurrio algo raro");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("El archivo non existe");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {
                Console.WriteLine("Aqui me he ejecutado, pase lo que pase");
            }
            Console.WriteLine("Aqui se sigue ejecutando");
        }
    }
}