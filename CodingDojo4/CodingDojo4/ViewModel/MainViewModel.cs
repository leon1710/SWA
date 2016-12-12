using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System;
using GalaSoft.MvvmLight.Command;
using System.Globalization;

namespace CodingDojo4.ViewModel
{
   
    public class MainViewModel : ViewModelBase
    {
        private string lastname = "";
        private string firstname = "";
        private int ssn;
        private String birthdate;
        private ObservableCollection<PersonVM> persons= new ObservableCollection<PersonVM>();
        private RelayCommand addBtnClickedCommand;

        //AddBtnClickedCommand= new RelayCommand(AddPerson);
        public MainViewModel()
        {
            AddBtnClickedCommand = new RelayCommand(AddPerson);
            // LoadData();
        }

        private void AddPerson()
        {
            Persons.Add(new PersonVM(firstname, lastname, ssn, DateTime.ParseExact(birthdate, "MM/dd/yyyy hh:mm:ss tt",
                                  CultureInfo.InvariantCulture)));
        }

        private void LoadData()
        {
            //persons.Add(new PersonVM("Leon", "Mueller", 23, DateTime.ParseExact("MM/dd/yyyy hh:mm:ss tt"));
        }

        public ObservableCollection<PersonVM> Persons
        {
            get
            {
                return persons;
            }

            set
            {
                persons = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public int Ssn
        {
            get
            {
                return ssn;
            }

            set
            {
                ssn = value;
            }
        }

        public string Birthdate
        {
            get
            {
                return birthdate;
            }

            set
            {
                birthdate = value;
            }
        }

        public RelayCommand AddBtnClickedCommand
        {
            get
            {
                return addBtnClickedCommand;
            }

            set
            {
                addBtnClickedCommand = value;
            }
        }
    }
}