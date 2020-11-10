using System;
using System.Collections.Generic;
using System.Text;

namespace SoftRestaurant
{
    interface IEstado
    {
        void Ordenar();
        void Pagar();
        void ReabrirMesa();
    }
}
