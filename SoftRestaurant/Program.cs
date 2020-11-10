using System;

namespace SoftRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IEstado mesa1 = new CCerrada();
            mesa1.Pagar();

            Console.ReadKey();
        }
    }
}
