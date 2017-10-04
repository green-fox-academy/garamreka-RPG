using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPG_game
{
    class Monster: Character
    {
        private static string pathSkeleton = @"./Assets/skeleton.png";
        private static string pathBoss = @"./Assets/boss.png";
        private static Random random = new Random();
        private static int numberOfSkeleton = 3;
        private static int numberOfBoss = 1;

        public static GameArea gameArea = new GameArea();

        public static void SetMonster(FoxDraw foxDraw)
        {
            RandomPositionOfMonster(foxDraw, pathBoss, numberOfBoss);
            RandomPositionOfMonster(foxDraw, pathSkeleton, numberOfSkeleton);
            
        }

        public static void RandomPositionOfMonster(FoxDraw foxDraw, string path, int maxMonster)
        {
            int numberOfMonster = 0;

            do
            {
                int randomX = random.Next(1, 10);
                int randomY = random.Next(1, 10);
                if (gameArea.board[randomX][randomY] == false)
                {
                    foxDraw.AddImage(path, randomX * gameArea.tileSize, randomY * gameArea.tileSize);
                    numberOfMonster++;
                }
            }
            while (numberOfMonster < maxMonster);
        }
    }
}
