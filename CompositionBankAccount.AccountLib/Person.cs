using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionBankAccount.Entities
{
    public abstract class Person: Entity
    {
        protected string firstname;
        protected string lastname;
        protected string ssn;

        public Person()
        {

        }
        public Person(int id, string firstname, string lastname, string ssn)
            : base(id)
        {
            Firstname = firstname;
            Lastname = lastname;
            Ssn = ssn;
        }

        public Person(string firstname, string lastname, string ssn)
            :this(default, firstname, lastname, ssn)
        {
        
        }

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Ssn { get => ssn; set => ssn = value; }

        public static (bool isValid, string errMsg) ValidateName(string name)
        {
            return (true, "");
        }

        public string(bool isValid, string errMsg) ValidateSsn(string ssn)
        {
            return (true, "");
        }
    }
}
