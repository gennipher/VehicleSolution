using ConsoleApp.Models;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car fusca;
            fusca = new Car();

            //################### Usando o carro ##################

            //            _______
            //           //  ||\ \
            //     _____//___||_\ \_______
            //     )  _ _    \            |
            //     | _ / \________ / \___ |
            //     ___\_ / ________\_ / ______



            //Console.WriteLine("Direção do Volante:");
            //Console.WriteLine("Velocidade: " + fusca.CurrentDirection + "km/h");
            //Console.WriteLine();

            //fusca.TurnLeft(90);
            //fusca.SpeedUp(70);
            //Console.WriteLine("Velocidade: " + fusca.CurrentSpeed + "km/h");
            //fusca.SpeedDown(10);
            //Console.WriteLine("Velocidade: " + fusca.CurrentSpeed + "km/h");
            //fusca.TurnRight(180);
            //fusca.SpeedDown(60);
            //Console.WriteLine("Velocidade: " + fusca.CurrentSpeed + "km/h");

            //control k - comenta
            //contral k u - descomenta
            //ascii art car

            //################### Usando o avião ##################

            //                    _
            //                  -=\`\
            //             |\ ____\_\__
            //           -=\c`""""""" "`)
            //              `~~~~~/ / ~~`
            //                -==/ /


            AirPlane boeing747;
            boeing747 = new AirPlane();

            boeing747.SpeedUp(100);
            boeing747.SpeedUp(100);
            boeing747.SpeedUp(100);
            boeing747.SpeedUp(100);
            boeing747.SpeedUp(100);

            boeing747.GoUp(100);
            boeing747.GoUp(100);
            boeing747.GoUp(100);
            boeing747.GoUp(100);
            boeing747.GoUp(100);
            boeing747.GoUp(200);
            boeing747.GoUp(200);

            for (int i = 0; i < 9; i++)
            {
                boeing747.GoDown(100);
                Console.WriteLine("Altura: " + boeing747.CurrentHeight + "m");
            }
            // ####################################################



        }
    }
}
