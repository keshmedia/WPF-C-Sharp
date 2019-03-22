using System.Windows;
namespace KeshCalculator
{
public partial class MainWindow : Window
    {
  long number1 = 0;
  long number2 = 0;
  string operation = "";

  public MainWindow()
  {
 InitializeComponent();
  }
  private void Btn1_Click(object sender, RoutedEventArgs e)
  {
 if(operation == "")
 {
number1 = (number1 * 10) + 1;
txtDisplay.Text = number1.ToString();
 }
 else
 {
number2 = (number2 * 10) + 1;
txtDisplay.Text = number2.ToString();
 }}
 private void Btn2_Click(object sender, RoutedEventArgs e)
 {
if (operation == "")
{
    number1 = (number1 * 10) + 2;
    txtDisplay.Text = number1.ToString();
}
else
{
    number2 = (number2 * 10) + 2;
    txtDisplay.Text = number2.ToString();
}}
 private void Btn3_Click(object sender, RoutedEventArgs e)
 {
 if (operation == "")
 {
     number1 = (number1 * 10) + 3;
     txtDisplay.Text = number1.ToString();
 }
 else
 {
     number2 = (number2 * 10) + 3;
     txtDisplay.Text = number2.ToString();
 }}
 private void Btn4_Click(object sender, RoutedEventArgs e)
 {
if (operation == "")
{
    number1 = (number1 * 10) + 4;
    txtDisplay.Text = number1.ToString();
}
else
{
    number2 = (number2 * 10) + 4;
    txtDisplay.Text = number2.ToString();
}}
 private void Btn5_Click(object sender, RoutedEventArgs e)
 {
if (operation == "")
{
    number1 = (number1 * 10) + 5;
    txtDisplay.Text = number1.ToString();
}
else
{
    number2 = (number2 * 10) + 5;
    txtDisplay.Text = number2.ToString();
}}
 private void Btn6_Click(object sender, RoutedEventArgs e)
 {
if (operation == "")
{
    number1 = (number1 * 10) + 6;
    txtDisplay.Text = number1.ToString();
}
else
{
    number2 = (number2 * 10) + 6;
    txtDisplay.Text = number2.ToString();
}}
 private void Btn7_Click(object sender, RoutedEventArgs e)
 {
if (operation == "")
{
    number1 = (number1 * 10) + 7;
    txtDisplay.Text = number1.ToString();
}
else
{
    number2 = (number2 * 10) + 7;
    txtDisplay.Text = number2.ToString();
}}
 private void Btn8_Click(object sender, RoutedEventArgs e)
 {
if (operation == "")
{
    number1 = (number1 * 10) + 8;
    txtDisplay.Text = number1.ToString();
}
else
{
    number2 = (number2 * 10) + 8;
    txtDisplay.Text = number2.ToString();
}}
 private void Btn9_Click(object sender, RoutedEventArgs e)
 {
     if (operation == "")
     {
number1 = (number1 * 10) + 9;
txtDisplay.Text = number1.ToString();
     }
     else
     {
number2 = (number2 * 10) + 9;
txtDisplay.Text = number2.ToString();
     }}
private void Btn0_Click(object sender, RoutedEventArgs e)
        {
 if (operation == "")
 {
     number1 = (number1 * 10) ;
     txtDisplay.Text = number1.ToString();
 }
 else
 {
     number2 = (number2 * 10) ;
     txtDisplay.Text = number2.ToString();
 }     }
private void BtnPlus_Click(object sender, RoutedEventArgs e)
{
    operation = "+";
    txtDisplay.Text = "0";
}
private void BtnMinus_Click(object sender, RoutedEventArgs e)
{
    operation = "-";
    txtDisplay.Text = "0";
}
private void BtnTimes_Click(object sender, RoutedEventArgs e)
{
    operation = "*";
    txtDisplay.Text = "0";
}
private void BtnDivide_Click(object sender, RoutedEventArgs e)
{
    operation = "/";
    txtDisplay.Text = "0";
}
private void BtnEquals_Click(object sender, RoutedEventArgs e)
{
switch (operation)
  {
  case "+":
      txtDisplay.Text = (number1 + number2).ToString();
      break;
  case "-":
      txtDisplay.Text = (number1 - number2).ToString();
      break;
  case "*":
      txtDisplay.Text = (number1 * number2).ToString();
      break;
  case "/":
      txtDisplay.Text = (number1 / number2).ToString();
      break;
            }   }
private void BtnClearEntry_Click(object sender, RoutedEventArgs e)
        {
 if (operation == "")
 {
     number1 = 0;         
 }
 else
 {
     number2 = 0;
 }
 txtDisplay.Text = "0";
}
private void BtnClear_Click(object sender, RoutedEventArgs e)
{
    number1 = 0;
    number2 = 0;
    operation = "";
    txtDisplay.Text = "0";
}
private void BtnBackspace_Click(object sender, RoutedEventArgs e)
{
 if (operation == "")
 {
     number1 = (number1 / 10);
     txtDisplay.Text = number1.ToString();
 }
 else
 {
     number2 = (number2 / 10);
     txtDisplay.Text = number2.ToString();
 }     }
private void BtnPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
if (operation == "")
{
    number1 *= -1;
    txtDisplay.Text = number1.ToString();
}
else
{
    number2  *= -1;
    txtDisplay.Text = number2.ToString();
               //THIS IS THE MAINWINDOW.XAML.CS //
        }    }   }}



