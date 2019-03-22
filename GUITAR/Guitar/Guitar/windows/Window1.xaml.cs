using System.Windows;

namespace Guitar.windows
{

    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            fWindow.Content = new FrameWindows.Page1();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            fWindow.Content = new FrameWindows.Page2();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            fWindow.Content = new FrameWindows.Page3();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            fWindow.Content = new FrameWindows.Page4();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            fWindow.Content = new FrameWindows.Page5();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            fWindow.Content = new FrameWindows.Page6();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            fWindow.Content = new FrameWindows.Page7();
System.Diagnostics.Process.Start("https://enniskillenmedia.wordpress.com/about-the-guitar/");
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            fWindow.Content = new FrameWindows.Page8();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            fWindow.Content = new FrameWindows.Page9();
        }
    }
}
