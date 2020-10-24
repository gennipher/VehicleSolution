using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Models.Interfaces
{
    public interface IMove
    {

        /*
        É como se a gente estivesse criando um contrato 
        de que o veículo deverá ter 
        um ACELERADOR, uma EMBREAGEM e um FREIO.
        */

        public void SpeedUp(int speed); //ACELERADOR
        public void SpeedDown(int speed); //FREIO

    }
}
