using System;
using System.Collections.Generic;
using System.Text;

namespace SoftRestaurant
{
    public class CCerrada : IEstado
    {
        public void Ordenar()
        {
            throw new NotImplementedException();
        }

        public void Pagar()
        {
             Console.WriteLine("La mesa está cerrada");
        }

        public void ReabrirMesa()
        {
            throw new NotImplementedException();
        }
    }
}
