using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
namespace search
{
public partial class MainWindow : Window, 
INotifyPropertyChanged
{
private string _searchText;
public string SearchText
{
   get { return _searchText; }
   set
   {
 _searchText = value;
 OnPropertyChanged("SearchText");
 OnPropertyChanged("MyFilteredItems");
   }  }
public List<string> MyItems { get; set; }
public IEnumerable<string> MyFilteredItems
{
 get
 {
 if (SearchText == null) return MyItems;
 return MyItems.Where(x => x.ToUpper().StartsWith(SearchText.ToUpper()));
     }  }
 public MainWindow()
        {
 InitializeComponent();
 MyItems = new List<string>()
 {
"Paddy O' Riordan ",

"dog ",
"cat",
"horse",
"fish",

 };
DataContext = this;
}
public event PropertyChangedEventHandler PropertyChanged;
void OnPropertyChanged(string name)
{
PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
  } }}
