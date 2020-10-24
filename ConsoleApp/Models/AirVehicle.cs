using ConsoleApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Models
{
    public abstract class AirVehicle : Vehicle, IFly
    {
        public int CurrentHeight { get; set; }

        public void GoDown(int height)
        {
            CurrentHeight = CurrentHeight - height;
        }

        public void GoUp(int height)
        {
            CurrentHeight = CurrentHeight + height;
        }

    }
}
