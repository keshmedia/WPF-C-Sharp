using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace Guitar.FrameWindows
{

    public partial class Page4 : Page
    {
        private int time = 3610;
        private DispatcherTimer Timer;
 
        public Page4()
        {
            InitializeComponent();
            InitializeComponent();
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                if (time <= 10)
                {
                    if (time % 2 == 0)
                    {
                        TBCountDown.Foreground = Brushes.Red;
                    }
                    else
                    {
                        TBCountDown.Foreground = Brushes.White;
                    }
                    time--;
                    TBCountDown.Text = string.Format("{0}:{1}",
                        time / 60, time % 60);
                }
                else
                {
                    time--;
                    TBCountDown.Text = string.Format("{0}:{1}",
                        time / 60, time % 60);
                }
            }
            else
            {
                Timer.Stop();
                MessageBox.Show("WELL DONE !!!  ");
            }
        }
    }
}

    



  
