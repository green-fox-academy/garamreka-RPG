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

        public static FoxDraw foxDraw;
        public static GameArea gameArea = new GameArea();

        public static void SetHero (FoxDraw foxDraw)
        {
            Hero.foxDraw = foxDraw;
            foxDraw.AddImage(pathHeroDown, gameArea.xCoordinate, gameArea.yCoordinate);
        }
        public static void MoveRight ()
        {
            foxDraw.AddImage(gameArea.floorPath, gameArea.xCoordinate, gameArea.yCoordinate);

            gameArea.xCoordinate += gameArea.tileSize;
            if (!gameArea.IsMap() || gameArea.isWall())
            {
                gameArea.xCoordinate -= gameArea.tileSize;
            }

            foxDraw.AddImage(pathHeroRight, gameArea.xCoordinate, gameArea.yCoordinate);

        }
        public static void MoveDown()
        {
            foxDraw.AddImage(gameArea.floorPath, gameArea.xCoordinate, gameArea.yCoordinate);

            gameArea.yCoordinate += gameArea.tileSize;
            if (!gameArea.IsMap() || gameArea.isWall())
            {
                gameArea.yCoordinate -= gameArea.tileSize;
            }

            foxDraw.AddImage(pathHeroDown, gameArea.xCoordinate, gameArea.yCoordinate);
        }
        public static void MoveLeft()
        {
            foxDraw.AddImage(gameArea.floorPath, gameArea.xCoordinate, gameArea.yCoordinate);

            gameArea.xCoordinate -= gameArea.tileSize;
            if (!gameArea.IsMap() || gameArea.isWall())
            {
                gameArea.xCoordinate += gameArea.tileSize;
            }

            foxDraw.AddImage(pathHeroLeft, gameArea.xCoordinate, gameArea.yCoordinate);
        }
        public static void MoveUp()
        {
            foxDraw.AddImage(gameArea.floorPath, gameArea.xCoordinate, gameArea.yCoordinate);

            gameArea.yCoordinate -= gameArea.tileSize;
            if (!gameArea.IsMap() || gameArea.isWall())
            {
                gameArea.yCoordinate += gameArea.tileSize;
            }

            foxDraw.AddImage(pathHeroUp, gameArea.xCoordinate, gameArea.yCoordinate);

        }
    }
}
