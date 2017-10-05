using System;
using System.Collections.Generic;
using GreenFox;
using System.IO;

namespace RPG_game
{
    public class GameArea
    {
        public string floorPath = @"./Assets/floor.png";
        public string wallPath = @"./Assets/wall.png";
        public int tileSize = 50;
        public int boardSize = 450;
        public int xCoordinate = 0;
        public int yCoordinate = 0;

        public List<string[]> GetMap()
        {
            string pathMap = @"../../Assets/map.txt";
            List<string[]> map = new List<string[]>();
            string[] monsterMatrixInput = File.ReadAllLines(pathMap);

            foreach (var line in monsterMatrixInput)
            {
                map.Add(line.Split(' '));
            }
            return map;
        }

        public void DrawMap (FoxDraw foxDraw)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < GetMap().Count; i++)
            {
                for (int j = 0; j < GetMap()[i].Length; j++)
                {
                    if (GetMap()[i][j] == "true")
                    {
                        foxDraw.AddImage(wallPath, x, y);
                    }
                    else
                    {
                        foxDraw.AddImage(floorPath, x, y);
                    }
                    x += tileSize;
                }
                y += tileSize;
                x = 0;
            }
        }
        public bool IsMap ()
        {
            return !(xCoordinate < 0 || xCoordinate > boardSize || yCoordinate < 0 || yCoordinate > boardSize);
        }
        public bool isWall ()
        {
            if (GetMap()[yCoordinate / tileSize][xCoordinate / tileSize] == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
