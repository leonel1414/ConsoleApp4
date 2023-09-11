using Entidades;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Libro libro = new Libro(248, "JAVA en 10 minutos", "Mario Molina", "Manual", "Programación", 10000);

            libro.Mostrar();
            libro.MostrarPrecio();
            //libro.MostrarPrecio(10000.43);
        }
    }
}