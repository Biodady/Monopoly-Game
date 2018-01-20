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
using System.Windows.Threading;

namespace Monopoly_Game
{
    /// <summary>
    /// Interaction logic for Play.xaml
    /// </summary>

    public partial class Play : Page
    {
        public Play()
        {

        }
        int Time_Click = 0, Time_Click2 = 0, startX = 0, startY = 0; // Initial x axis -> startX
        int x1 = 605, x2 = 540, x3 = 480, x4 = 415, x5 = 355, x6 = 290; // Default distance of dice
        int y1 = 438, y2 = 390, y3 = 342;
        int currentDis = 0;  // CurrentDistance
        int dice1 = 0, totalDice = 0; // Random dice
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //this.Focus();
            //DispatcherTimer timerPlayer = new DispatcherTimer();
            //timerPlayer.Tick += new EventHandler(dispatTick);
            //timerPlayer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            //timerPlayer.Start();

            //DispatcherTimer timerPlayer2 = new DispatcherTimer();
            //timerPlayer2.Tick += new EventHandler(dispatTick2);
            //timerPlayer2.Interval = new TimeSpan(0, 0, 0, 0, 100);
            //timerPlayer2.Start();
        }

        private void dispatTick2(object sender, EventArgs e)
        {

        }

        private void dispatTick(object sender, EventArgs e)
        {
            //if (Time_Click == 1)
            //{
            //    checkStart.Text = startX.ToString();
            //    if (totalDice == 1 && Canvas.GetLeft(player) >= (startX - 30))
            //    {
            //        Canvas.SetLeft(player, Canvas.GetLeft(player) - 20);
            //        startX -= 30;
            //    }
            //    else if (totalDice == 2 && Canvas.GetLeft(player) >= startX - 60)
            //    {
            //        Canvas.SetLeft(player, Canvas.GetLeft(player) - 20);
            //        startX -= 60;
            //    }
            //    else if (totalDice == 3 && Canvas.GetLeft(player) >= startX - 150)
            //    {
            //        Canvas.SetLeft(player, Canvas.GetLeft(player) - 20);
            //        startX -= 150;
            //    }
            //    else if (totalDice == 4 && Canvas.GetLeft(player) >= startX - 180)
            //    {
            //        Canvas.SetLeft(player, Canvas.GetLeft(player) - 20);
            //        startX -= 180;
            //    }
            //    else if (totalDice == 5 && Canvas.GetLeft(player) >= startX - 210)
            //    {
            //        Canvas.SetLeft(player, Canvas.GetLeft(player) - 20);
            //        startX -= 210;
            //    }
            //    else if (totalDice == 6 && Canvas.GetLeft(player) >= startX - 240)
            //    {
            //        Canvas.SetLeft(player, Canvas.GetLeft(player) - 20);
            //        startX -= 240;
            //    }
            //}
            //else if (Time_Click > 1)
            //{
            //    checkStart.Text = startX.ToString();
            //    if (totalDice == 1 && Canvas.GetLeft(player) >= (startX - 30))
            //    {
            //        Canvas.SetLeft(player, Canvas.GetLeft(player) - 20);
            //        startX -= 30;
            //    }
            //    else if (totalDice == 2 && Canvas.GetLeft(player) >= startX - 60)
            //    {
            //        Canvas.SetLeft(player, Canvas.GetLeft(player) - 20);
            //        startX -= 60;
            //    }
            //    else if (totalDice == 3 && Canvas.GetLeft(player) >= startX - 150)
            //    {
            //        Canvas.SetLeft(player, Canvas.GetLeft(player) - 20);
            //        startX -= 150;
            //    }
            //    else if (totalDice == 4 && Canvas.GetLeft(player) >= startX - 180)
            //    {
            //        Canvas.SetLeft(player, Canvas.GetLeft(player) - 20);
            //        startX -= 180;
            //    }
            //    else if (totalDice == 5 && Canvas.GetLeft(player) >= startX - 210)
            //    {
            //        Canvas.SetLeft(player, Canvas.GetLeft(player) - 20);
            //        startX -= 210;
            //    }
            //    else if (totalDice == 6 && Canvas.GetLeft(player) >= startX - 240)
            //    {
            //        Canvas.SetLeft(player, Canvas.GetLeft(player) - 20);
            //        startX -= 240;
            //    }
            //}
        }



        private void Page_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F9)
            {
                
                Time_Click = 0;
            }

        }

        private void btnRoll_Click(object sender, RoutedEventArgs e)
        {
            //Random rnd = new Random();
            //dice1 = rnd.Next(1, 2);
            totalDice = 1;
            resultShow.Text = totalDice.ToString();
            Time_Click = Time_Click + 1;
            Time_Click2 = Time_Click2 + 1;
            timeClick.Text = Time_Click.ToString();
            timeClick2.Text = Time_Click2.ToString();
            current.Text = currentDis.ToString();
            checkStart.Text = startX.ToString();
            /*x axis*/
            if (Canvas.GetLeft(player) >=109)
            {
                if (Time_Click == 1)
                {

                    if (totalDice == 1 )
                    {
                        startX = 667;
                        Canvas.SetLeft(player, x1);
                        currentDis = x1;
                    }
                    else if (totalDice == 2 )
                    {
                        startX = 665;
                        Canvas.SetLeft(player, x2);
                        currentDis = x2;
                    }
                    else if (totalDice == 3 )
                    {
                        startX = 663;
                        Canvas.SetLeft(player, x3);
                        currentDis = x3;
                    }
                    else if (totalDice == 4 )
                    {
                        startX = 661;
                        Canvas.SetLeft(player, x4);
                        currentDis = x4;
                    }
                    else if (totalDice == 5 )
                    {
                        startX = 659;
                        Canvas.SetLeft(player, x5);
                        currentDis = x5;
                    }
                    else if (totalDice == 6 )
                    {
                        startX = 657;
                        Canvas.SetLeft(player, x6);
                        currentDis = x6;
                    }
                }
                else if (Time_Click > 1)
                {
                    if (totalDice == 1 && Canvas.GetLeft(player) >= currentDis)
                    {
                        startX = 667;
                        currentDis = (currentDis - (startX - x1));
                        Canvas.SetLeft(player, currentDis);
                    }
                    else if (totalDice == 2 && Canvas.GetLeft(player) >= currentDis)
                    {
                        startX = 665;
                        currentDis = (currentDis - (startX - x2));
                        Canvas.SetLeft(player, currentDis);
                    }
                    else if (totalDice == 3 && Canvas.GetLeft(player) >= currentDis)
                    {
                        startX = 663;
                        currentDis = (currentDis - (startX - x3));
                        Canvas.SetLeft(player, currentDis);
                    }
                    else if (totalDice == 4 && Canvas.GetLeft(player) >= currentDis)
                    {
                        startX = 661;
                        currentDis = (currentDis - (startX - x4));
                        Canvas.SetLeft(player, currentDis);
                    }
                    else if (totalDice == 5 && Canvas.GetLeft(player) >= currentDis)
                    {
                        startX = 659;
                        currentDis = (currentDis - (startX - x5));
                        Canvas.SetLeft(player, currentDis);
                    }
                    else if (totalDice == 6 && Canvas.GetLeft(player) >= currentDis)
                    {
                        startX = 657;
                        currentDis = (currentDis - (startX - x6));
                        Canvas.SetLeft(player, currentDis);
                    }
                } 
            }
            /*y axis*/
            else if (Canvas.GetTop(player) <= 500 && Canvas.GetLeft(player) < 109)
            {
                if (Time_Click == 1)
                {
                    if (totalDice == 1 )
                    {
                        startY = 500;
                        Canvas.SetTop(player, y1);
                        currentDis = y1;
                    }
                    else if (totalDice == 2)
                    {
                        startY = 500;
                        Canvas.SetTop(player, y2);
                        currentDis = y2;
                    }
                    else if (totalDice == 3)
                    {
                        startY = 500;
                        Canvas.SetTop(player, y3);
                        currentDis = y3;
                    }
                }
                else if (Time_Click > 1)
                {
                    if (totalDice == 1 && Canvas.GetTop(player) >= currentDis)
                    {
                        startY = 500;
                        currentDis = (currentDis - (startY - (y1 + 12)));
                        Canvas.SetTop(player, currentDis);
                    }
                    else if (totalDice == 2 && Canvas.GetTop(player) >= currentDis)
                    {
                        startY = 500;
                        currentDis = (currentDis - (startY - (y2 + 12)));
                        Canvas.SetTop(player, currentDis);
                    }
                    else if (totalDice == 3 && Canvas.GetTop(player) >= currentDis)
                    {
                        startY = 500;
                        currentDis = (currentDis - (startY - (y3 + 12)));
                        Canvas.SetTop(player, currentDis);
                    }
                }

            }

        }
    }
}
