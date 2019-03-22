using System;
using System.Windows;
using System.Windows.Threading;
namespace Guitar
    {
        public partial class Splash : Window
    {
        DispatcherTimer dT = new DispatcherTimer();
        public Splash()
    {
       InitializeComponent();
       dT.Tick += new EventHandler(Dt_Tick);
       dT.Interval = new TimeSpan(0, 0, 8); 
  // IF YOU NEED TO CHANGE THE TIMINGS OF THE SPLASH SCREEN//
       dT.Start();
   }
        private void Dt_Tick(object sender, EventArgs e)
   {
       MainWindow db = new MainWindow();
       db.Show();
       dT.Stop();
       this.Close();           }   }   }
