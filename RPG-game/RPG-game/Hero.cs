using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPG_game
{
    class Hero
    {
        private static string pathHeroDown = @"./Assets/hero-down.png";
        private static string pathHeroLeft = @"./Assets/hero-left.png";
        private static string pathHeroRight = @"./Assets/hero-right.png";
        private static string pathHeroUp = @"./Assets/hero-up.png";

        public void SetHero (FoxDraw foxDraw)
        {
            foxDraw.AddImage(pathHeroDown, 0, 0);
        }
    }
}
