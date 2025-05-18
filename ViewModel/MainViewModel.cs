using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using ZFTaskApplication.Model;
using static System.Net.Mime.MediaTypeNames;

namespace ZFTaskApplication.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string name;
        private string age;
        private Person selectedPerson;
        private ObservableCollection<Person> datalist = new ObservableCollection<Person>();
        public DelegateCommand AddCommand { get; set; }
        public DelegateCommand DltCommand { get; set; }

        public MainViewModel()
        {
            AddCommand = new DelegateCommand(AddPerson);
            DltCommand = new DelegateCommand(DeletePerson);
        }

        public string Name
        {
            get => name;
            set 
            { 
                name = value; 
                OnPropertyChanged(nameof(Name)); 
            }
        }

        public string Age
        {
            get => age;
            set 
            { 
                age = value; 
                OnPropertyChanged(nameof(Age)); 
            }
        }

        public Person SelectedPerson
        {
            get => selectedPerson;
            set 
            { 
                selectedPerson = value; 
                OnPropertyChanged(nameof(SelectedPerson)); 
            }
        }

        public ObservableCollection<Person> DataList
        {
            get { return datalist; }
            set
            {
                datalist = value;
                OnPropertyChanged(nameof(DataList));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AddPerson()
        {
            if (string.IsNullOrEmpty(Name) || !Name.Any(x => char.IsLetter(x)))
            {
                MessageBox.Show("Name Should Contain Characters");
            }
            else if (string.IsNullOrEmpty(Age) || !int.TryParse(Age, out _))
            {
                MessageBox.Show("Age must be a valid number");
            }
            else
            {
                DataList.Add(new Person() { Name = Name, Age = Age });
                Name = "";
                Age = "";
            }
        }

        public void DeletePerson()
        {
            if (SelectedPerson == null)
            {
                MessageBox.Show("Please Select a Member to Delete");
            }
            else if (DataList.Contains(SelectedPerson))
            {
                DataList.Remove(SelectedPerson);
            }
        }
    }
}
