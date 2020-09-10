using System;

namespace Modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            Player firstPlayer = new Player();
            firstPlayer.character = "Ash";
            firstPlayer.xCoordinate = 0;
            firstPlayer.yCoordinate = 0;
            firstPlayer.zCoordinate = 0;
            firstPlayer.speed = 100;
            firstPlayer.weaponName = "R4-C";
            firstPlayer.magSize = 31;
            firstPlayer.mags = 8;
            firstPlayer.grenade = 1;

            Player secondPlayer = new Player();
            secondPlayer.character = "Capitao";
            secondPlayer.xCoordinate = 5;
            secondPlayer.yCoordinate = 5;
            secondPlayer.zCoordinate = 0;
            secondPlayer.speed = 90;
            secondPlayer.weaponName = "M249";
            secondPlayer.magSize = 101;
            secondPlayer.mags = 3;
            secondPlayer.grenade = 0;


            System.Console.WriteLine(firstPlayer.xCoordinate + secondPlayer.xCoordinate);
            Console.ReadLine();

        }
    }
}
