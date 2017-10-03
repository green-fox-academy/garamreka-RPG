using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPG_game
{
    class GameArea
    {
        private static string floorPath = @"./Assets/floor.png";
        private static string wallPath = @"./Assets/wall.png";
        private static int boardSize = 50;

        //public string FloorPath  
        //{
        //    get { return floorPath; }
        //    set { floorPath = @"./Assets/floor.png"; }
        //}
        
        public void DrawFloor (FoxDraw foxDraw)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    foxDraw.AddImage(floorPath, x, y);
                    x += boardSize;
                }
                y += boardSize;
                x = 0;
            }
        }
        public void DrawWall (FoxDraw foxDraw)
        {
            foxDraw.AddImage(wallPath, 0, 50);
        }
    }
}
