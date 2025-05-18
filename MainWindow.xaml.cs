using System.Windows;

namespace ZFTaskApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModel.MainViewModel();
        }

        //public ObservableCollection<Person> DataList
        //{
        //    get { return datalist; }
        //    set 
        //    { 
        //        datalist = value;
        //        OnPropertyChanged(nameof(DataList));
        //    }
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

        //private void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        //private void Addbtn_Click(object sender, RoutedEventArgs e)
        //{
        //    if(nametxtbox.Text.Length == 0)
        //    {
        //        MessageBox.Show("Please enter a Name.");
        //    }
        //    else if(agetxtbox.Text.Length != 0 && agetxtbox.Text.Any(x => char.IsLetter(x)))
        //    {
        //        MessageBox.Show("Please enter the Age in Number format");
        //    }
        //    else if(agetxtbox.Text.Length == 0)
        //    {
        //        MessageBox.Show("Please enter the Age");
        //    }
        //    else
        //    {
        //        DataList.Add(new Person() { Name = nametxtbox.Text, Age = agetxtbox.Text });
        //        nametxtbox.Clear();
        //        agetxtbox.Clear();
        //    }
        //    counttxtblk.Text = DataList.Count.ToString();
        //}

        //private void Dltbtn_Click(object sender, RoutedEventArgs e)
        //{
        //    if(listview.SelectedIndex != -1)
        //    {
        //        DataList.RemoveAt(listview.SelectedIndex);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select an item to Remove");
        //    }
        //    counttxtblk.Text = DataList.Count.ToString();
        //}
    }
}