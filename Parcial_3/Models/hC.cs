using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_3.Models
{
    class hC : IMaquinaState
    {
        Maquina atm;
        public hC()
        {
            atm = new Maquina();
        }
        public void ejctCard()
        {
            Console.WriteLine("Tarjeta Retirada con éxito");
        }
        public void enterPin()
        {
            Console.WriteLine("Escribir PIN:");
            int pin = int.Parse(Console.ReadLine());
            if (atm._pin == pin)
            {
                Console.WriteLine("Inserte Cantidad: ");
                int cantidad = int.Parse(Console.ReadLine());
                if (cantidad > atm._balance)
                {
                    Console.WriteLine("El dinero no se puede retirar debido al bajo saldo");
                }
                else
                {
                    atm._balance = atm._balance - cantidad;
                    Console.WriteLine("Por Favor recoja su efectivo");
                    Console.WriteLine("Saldo {0}", atm._balance);
                }
            }
            else
            {
                Console.WriteLine("Pin Incorrecto");
            }
        }

        public void insertCard()
        {
            Console.WriteLine("no puede insertar la tarjeta");
        }
    }
}
