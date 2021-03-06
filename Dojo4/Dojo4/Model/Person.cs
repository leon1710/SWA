﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo4.Model
{
    public class Person
    {
        private string firstname;
        private string lastname;
        private int ssn;
        private DateTime birthdate;

        public Person(string firstname, string lastname, int ssn, DateTime birthdate )
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.ssn = ssn;
            this.birthdate = birthdate;
        }

        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
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

    }
}
