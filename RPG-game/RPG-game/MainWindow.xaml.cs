using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace RPG_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            var gameArea = new GameArea();

            gameArea.DrawBoard(foxDraw);
            Hero.SetHero(foxDraw);
            Monster.SetMonster(foxDraw);
        }

        private void WindowKey(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                Hero.MoveLeft();
            }

            if (e.Key == Key.Right)
            {
                Hero.MoveRight();
            }

            if (e.Key == Key.Down)
            {
                Hero.MoveDown();
            }

            if (e.Key == Key.Up)
            {
                Hero.MoveUp();
            }
        }
    }
}
