using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace Dojo4.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<PersonVM> personslist = new ObservableCollection<PersonVM>();
        private string firstname = "";
        private string lastname = "";
        private int ssn = 0;
        private DateTime birthdate = DateTime.Today;
        
        //private bool checkIfFileExists = false;

        private const string fileLoacation = "data.csv";

        private RelayCommand addBtnCommand;
        private RelayCommand saveCommand;
        private RelayCommand loadCommand;

        public MainViewModel()
        {
            //AddBtnCommand = new RelayCommand(Add, () => { return (Lastname.Length > 2); });
            AddBtnCommand = new RelayCommand(Add, CheckLastNameLength);
            SaveCommand = new RelayCommand(SaveToCsv);
            LoadCommand = new RelayCommand(LoadFromCsv, () => { return CheckIfFileExists(); });
        }

        private bool CheckLastNameLength()
        {
            return Lastname.Length > 2;
        }

        private bool BtnEnabled()
        {
            throw new NotImplementedException();
        }

        public bool CheckIfFileExists()
        {
            return File.Exists(fileLoacation);
        }

        private void LoadFromCsv()
        {
            String[] lines = File.ReadAllLines(fileLoacation);
            PersonVM person = null;
            String[] details;
            foreach (var item in lines)
            {
                details = item.Split(';');
                //if (person == null)
                //{
                    person = new PersonVM(details[0], details[1],int.Parse(details[2]), DateTime.Parse(details[3]));
                //}
                Personslist.Add(person);
            }
            //Personslist.Add(person);

        }

        private void SaveToCsv()
        {
           
            string data = "";

            foreach (var item in Personslist)
            {
                data += item.Firstname + ";" + item.Lastname + ";"+ item.Ssn + ";"
                     + item.Birthdate + ";"
                        + "\r\n";
            }
            File.WriteAllText(fileLoacation, data);
     
        }

        private void Add()
        {
            Personslist.Add(new PersonVM(Firstname, Lastname, Ssn, Birthdate));
        }

        public int Ssn
        {
            get { return ssn; }
            set { ssn = value; }
        }


        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }



        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        

        public ObservableCollection<PersonVM> Personslist
        {
            get
            {
                return personslist;
            }

            set
            {
                personslist = value;
            }
        }

        public RelayCommand AddBtnCommand
        {
            get
            {
                return addBtnCommand;
            }

            set
            {
                addBtnCommand = value;
            }
        }

        public DateTime Birthdate
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


        public RelayCommand SaveCommand
        {
            get
            {
                return saveCommand;
            }

            set
            {
                saveCommand = value;
            }
        }

        public RelayCommand LoadCommand
        {
            get
            {
                return loadCommand;
            }

            set
            {
                loadCommand = value;
            }
        }

        

        
    }
}