using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InpcWpfApplication.DTO
{
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
}
