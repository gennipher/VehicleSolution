using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Models.Interfaces
{
    public interface IFly
    {
        public void GoUp(int height);
        public void GoDown(int height);
    }
}
