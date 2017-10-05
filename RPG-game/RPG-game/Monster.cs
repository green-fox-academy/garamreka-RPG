using System;
using System.Collections.Generic;
using GreenFox;
using System.IO;

namespace RPG_game
{
    class Monster: Character
    {
        private static string pathSkeleton = @"./Assets/skeleton.png";
        private static string pathBoss = @"./Assets/boss.png";
        private static Random random = new Random();
        private static int numberOfSkeleton = 3;
        private static int numberOfBoss = 1;

        public static List<string[]> MonsterMatrix ()
        {
            string pathMonsterMatrix = @"../../Assets/matrixForMonsters.txt";
            List<string[]> monsterMatrix = new List<string[]>();
            string[] monsterMatrixInput = File.ReadAllLines(pathMonsterMatrix);

            foreach (var line in monsterMatrixInput)
            {
                monsterMatrix.Add(line.Split(' '));
            }
            return monsterMatrix;
        }
        
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
                int randomX = random.Next(0, 10);
                int randomY = random.Next(0, 10);
                if (MonsterMatrix()[randomY][randomX] == "false")
                {
                    foxDraw.AddImage(path, randomX * gameArea.tileSize, randomY * gameArea.tileSize);
                    numberOfMonster++;
                    MonsterMatrix()[randomY][randomX] = "true";
                }
            }
            while (numberOfMonster < maxMonster);
        }
    }
}
