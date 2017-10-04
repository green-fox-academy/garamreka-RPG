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
        //public bool isWall = false;
        public int xCoordinate = 0;
        public int yCoordinate = 0;

        public List<string[]> board = new List<string[]>()
        {
            new string[] {"floor", "floor", "floor", "wall", "floor", "wall", "floor", "floor", "floor", "floor"},
            new string[] {"floor", "floor", "floor", "wall", "floor", "wall", "floor", "wall", "wall", "floor"},
            new string[] {"floor", "wall", "wall", "wall", "floor", "wall", "floor", "wall", "wall", "floor"},
            new string[] {"floor", "floor", "floor", "floor", "floor", "wall", "floor", "floor", "floor", "floor"},
            new string[] { "wall", "wall", "wall", "wall", "floor", "wall", "wall", "wall", "wall", "floor"},
            new string[] {"floor", "wall", "floor", "wall", "floor", "floor", "floor", "floor", "wall", "floor"},
            new string[] {"floor", "wall", "floor", "wall", "floor", "wall", "wall", "floor", "wall", "floor"},
            new string[] {"floor", "floor", "floor", "floor", "floor", "wall", "wall", "floor", "wall", "floor"},
            new string[] {"floor", "wall", "wall", "wall", "floor", "floor", "floor", "floor", "wall", "floor"},
            new string[] {"floor", "floor", "floor", "wall", "floor", "wall", "wall", "floor", "floor", "floor"}

        };

        
        public void DrawFloor (FoxDraw foxDraw)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < board.Count; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == "wall")
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
        public bool IsTileWalkable ()
        {
            return !(xCoordinate < 0 || xCoordinate > boardSize || yCoordinate < 0 || yCoordinate > boardSize);
        }
    }
}
