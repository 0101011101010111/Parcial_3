using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_3.Models
{
    public class Maquina : IMaquinaState
    {
        private IMaquinaState _state;
        public int _balance = 5000;
        public int _pin = 1234;
        public Maquina()
        {
            _state = new nCs();
        }
         void setMaquina(IMaquinaState state)
        {
            this._state = state;
        }
        public void ejctCard()
        {
            _state.ejctCard();
            if(_state is hC)
            {
                _state = new nCs();
                Console.WriteLine("El estado cambio");
                Console.WriteLine(_state.GetType().Name);
            }
        }
        public void enterPin()
        {
            if(_state is hC)
            {
                _state.enterPin();
            }
        }
        public void insertCard()
        {
            if(_state is nCs)
            {
                _state = new hC();
                Console.WriteLine("El estado cambio");
                Console.WriteLine(_state.GetType().Name);
            }
        }
    }
}
