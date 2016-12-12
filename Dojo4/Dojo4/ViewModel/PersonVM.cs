using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using Dojo4.Model;

namespace Dojo4.ViewModel
{
    public class PersonVM : ViewModelBase
    {
        private Person person;

        public PersonVM(string lastname, string firstname, int ssn, DateTime birthdate)
        {
            this.person = new Person(lastname, firstname, ssn, birthdate);
        }


        public DateTime Birthdate
        {
            get { return person.Birthdate; }
            set { person.Birthdate = value; RaisePropertyChanged(); }
        }


        public int Ssn
        {
            get { return person.Ssn; }
            set { person.Ssn = value; RaisePropertyChanged(); }
        }


        public string Lastname
        {
            get { return person.Lastname; }
            set { person.Lastname = value; RaisePropertyChanged(); }
        }


        public string Firstname
        {
            get { return person.Firstname; }
            set { person.Firstname = value; RaisePropertyChanged(); }
        }
    }
}
