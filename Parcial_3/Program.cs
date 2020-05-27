using System;
using Parcial_3.Models;
namespace Parcial_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maquina atm = new Maquina();

            atm.enterPin();
            atm.ejctCard();
            atm.insertCard();
            
            atm.enterPin();
            atm.ejctCard();
            atm.insertCard();
            

            Console.ReadLine();
        }
          
    }
}
