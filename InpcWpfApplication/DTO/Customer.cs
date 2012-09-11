using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PostSharp.Toolkit.Domain;

namespace InpcWpfApplication.DTO
{
    [NotifyPropertyChanged]
    class Entity
    {

    }

    
    class Customer : Entity
    {
        private string _lastName;
        private Address _address;

        public string FirstName { get; set; }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        //[NotifyPropertyChangedIgnore]
        public string FullName { get { return this.GetFullName(); } }

        public string GetFullName()
        {
            return string.Join(" ", this.FirstName, this.LastName);
        }

        public void Reset()
        {
            this.FirstName = null;
            this._lastName = null;
            this._address = new Address();
        }


    }

    class Address : Entity
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Town { get; set; }
        public string PostalCode { get; set; }
    }
}
