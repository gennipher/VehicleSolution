using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Models.Interfaces
{
    public interface IDirection
    {

        //Representa um VOLANTE ou algo do tipo.

        public void TurnLeft(int degrees);
        public void TurnRight(int degrees);
    }
}
