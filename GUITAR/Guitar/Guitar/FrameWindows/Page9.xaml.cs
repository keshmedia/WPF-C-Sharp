using System.Windows;
using System.Windows.Controls;
namespace Guitar.FrameWindows
{
    public partial class Page9 : Page
    {
 public Page9()
 {
     InitializeComponent();
 }
 private void Btn1_Click(object sender, RoutedEventArgs e)
 {
 System.Media.SoundPlayer player = new System.Media.SoundPlayer
(@"Chords\Achord.wav");
 player.Play();
        }
       private void Btn2_Click(object sender, RoutedEventArgs e)
        {
System.Media.SoundPlayer player = new System.Media.SoundPlayer
(@"Chords\Bchord.wav");
player.Play();
        }
        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer
(@"Chords\Cchord.wav");
            player.Play();
        }
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer
(@"Chords\Dchord.wav");
            player.Play();
        }
        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer
(@"Chords\Echord.wav");
            player.Play();
        }
        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer
(@"Chords\Fchord.wav");
            player.Play();
        }
        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer
(@"Chords\Gchord.wav");
            player.Play();
        }
        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer
(@"Tuning\lowEnote.wav");
            player.Play();
        }
        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer
(@"Tuning\Anote.wav");
            player.Play();
        }
        private void Btn10_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer
(@"Tuning\Dnote.wav");
            player.Play();
        }
        private void Btn11_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer
(@"Tuning\Gnote.wav");
            player.Play();
        }
        private void Btn12_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer
(@"Tuning\Bnote.wav");
            player.Play();
        }
        private void Btn13_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer
(@"Tuning\highEnote.wav");
            player.Play();
        }
        private void Btn14_Click(object sender, RoutedEventArgs e)
        {
 Window sW = new windows.Window4();
 sW.Show();
        }  }}
