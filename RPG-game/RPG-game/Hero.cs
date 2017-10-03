using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPG_game
{
    class Hero : Character
    {
        private static string pathHeroDown = @"./Assets/hero-down.png";
        private static string pathHeroLeft = @"./Assets/hero-left.png";
        private static string pathHeroRight = @"./Assets/hero-right.png";
        private static string pathHeroUp = @"./Assets/hero-up.png";
        public static int xCoordinate = 0;
        public static int yCoordinate = 0;

        public static FoxDraw foxDraw;
        public static GameArea gameArea = new GameArea();

        public static void SetHero (FoxDraw foxDraw)
        {
            Hero.foxDraw = foxDraw;
            foxDraw.AddImage(pathHeroDown, xCoordinate, yCoordinate);
        }
        public static void MoveRight ()
        {
            foxDraw.AddImage(gameArea.FloorPath, xCoordinate, yCoordinate);
            foxDraw.AddImage(pathHeroRight, xCoordinate + 50, yCoordinate);
            xCoordinate += 50;
        }
        public static void MoveDown()
        {
            foxDraw.AddImage(gameArea.FloorPath, xCoordinate, yCoordinate);
            foxDraw.AddImage(pathHeroDown, xCoordinate, yCoordinate + 50);
            yCoordinate += 50;
        }
        public static void MoveLeft()
        {
            foxDraw.AddImage(gameArea.FloorPath, xCoordinate, yCoordinate);
            foxDraw.AddImage(pathHeroLeft, xCoordinate - 50, yCoordinate);
            xCoordinate -= 50;
        }
        public static void MoveUp()
        {
            foxDraw.AddImage(gameArea.FloorPath, xCoordinate, yCoordinate);
            foxDraw.AddImage(pathHeroUp, xCoordinate, yCoordinate - 50);
            yCoordinate -= 50;
        }
    }
}
