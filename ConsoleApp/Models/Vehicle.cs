using ConsoleApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Models
{
    public abstract class Vehicle : IMove, IDirection
    {

        public int CurrentSpeed { get; set; }
        public int CurrentDirection { get; set;  }

        public void SpeedDown(int speed)
        {
            CurrentSpeed = CurrentSpeed - speed;

        }

        public void SpeedUp (int speed)
        {
            CurrentSpeed = CurrentSpeed + speed;
        }

        public void TurnLeft(int degress)
        {
            CurrentDirection = CurrentDirection - degress;
        }

        public void TurnRight(int degress)
        {
            CurrentDirection = CurrentDirection + degress;
        }

    }
}
