using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_3.Models
{
    class nCs : IMaquinaState
    {
        public void ejctCard()
        {
            Console.WriteLine("No hay ninguna tajeta en el Cajero");
        }

        public void enterPin()
        {
            Console.WriteLine("No puedes retirar dinero");
        }

        public void insertCard()
        {
            Console.WriteLine("Insertar Tarjeta");
        }
    }
}
