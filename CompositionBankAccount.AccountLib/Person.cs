using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionBankAccount.Entities
{
    public abstract class Person: Entity
    {
        #region Fields
        protected string firstname;
        protected string lastname;
        protected string ssn;
        #endregion

        #region Constructors
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
        #endregion

        #region Properties
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Ssn { get => ssn; set => ssn = value; }
        #endregion

        #region Methods
        public static (bool isValid, string errMsg) ValidateName(string name)
        {
            
            if (name is null)
            {
                return (false, "Name is null");
            }

            if (int.TryParse(name, out int result))
            {
                return (false, "Name cant be a number");
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                return (false, "Name only contains white spaces");
            }

            if (name.Trim().Length <= 1)
            {
                return (false, "Name must be longer than one characters");
            }
            return (true, "");
        }
        public static (bool isValid, string errMsg) ValidateSsn(string ssn)
        {
            return (true, "");
        }
        #endregion
    }
}
