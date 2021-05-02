using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace LW_
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name;
        public string Name
        {
            get => name;
            set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); }
        }
        private string surname;
        public string Surname
        {
            get => surname;
            set { surname = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Surname")); }
        }
        private string dateOfBirth;
        public string DateOfBirth
        {
            get => dateOfBirth;
            set { dateOfBirth = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DateOfBirth")); }
        }
        private int birthNumber;
        public int BirthNumber
        {
            get => birthNumber;
            set { birthNumber = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BirthNumber")); }
        }
        //public static Dictionary<string, Person> AllPeople = new Dictionary<string, Person>();
        public static ObservableCollection<Person> AllPeople { get; set; } = new ObservableCollection<Person>();
        public static void InitPersons()
        {
            AllPeople.Add(new Person
            {
                Name = "Jan",
                Surname = "Vavra",
                DateOfBirth = "13.June 2002",
                BirthNumber = 25263732,

            }) ;

            AllPeople.Add(new Person
            {
                Name = "Dan",
                Surname = "Vavra",
                DateOfBirth = "13.June 2002",
                BirthNumber = 15463732,

            });
        }
    }
}
