using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

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

        public List<bool[]> map = new List<bool[]>()
        {
            new bool[] {false, false, false, true, false, true, false, false, false, false},
            new bool[] { false, false, false, true, false, true, false, true, true, false},
            new bool[] { false, true, true, true, false, true, false, true, true, false},
            new bool[] { false, false, false, false, false, true, false, false, false, false},
            new bool[] { true, true, true, true, false, true, true, true, true, false},
            new bool[] { false, true, false, true, false, false, false, false, true, false},
            new bool[] { false, true, false, true, false, true, true, false, true, false},
            new bool[] { false, false, false, false, false, true, true, false, true, false},
            new bool[] { false, true, true, true, false, false, false, false, true, false},
            new bool[] { false, false, false, true, false, true, true, false, false, false }

        };

        public void DrawMap (FoxDraw foxDraw)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < map.Count; i++)
            {
                for (int j = 0; j < map[i].Length; j++)
                {
                    if (map[i][j] == true)
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
            return map[yCoordinate / tileSize][xCoordinate / tileSize];
        }
    }
}
