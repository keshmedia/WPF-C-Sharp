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

namespace Guitar.FrameWindows
{
    public partial class Page6 : Page
    {
        private int time = 1810; 
        private DispatcherTimer Timer;
        public Page6()
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
 MessageBox.Show("BREAK IS OVER, TIME TO GET BACK TO WORK !!!  ");
            }
        }
    }
}

