using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InpcWpfApplication.DTO;
using PostSharp.Toolkit.Domain;

namespace InpcWpfApplication.ModelView
{
    [NotifyPropertyChanged]
    class CustomerModelView
    {
        private Customer customer;

        public CustomerModelView(Customer customer)
        {
            this.customer = customer;
        }

        public string FirstName
        {
            get { return this.customer.FirstName; }
            set { this.customer.FirstName = value; }
        }

        public string LastName
        {
            get { return this.customer.LastName; }
            set { this.customer.LastName = value; } 
        }

        public Address Address { get { return this.customer.Address; } }

        public string FullName { get { return this.customer.FullName; } }

        public string BusinessCard
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(this.FirstName);
                stringBuilder.Append(" ");
                stringBuilder.Append(this.LastName);
                stringBuilder.AppendLine();
                stringBuilder.AppendLine(this.customer.Address.Line1);
                string line2 = this.customer.Address.Line2;
                if (!string.IsNullOrWhiteSpace(line2))
                {
                    stringBuilder.AppendLine(line2);
                }
                stringBuilder.Append(this.customer.Address.PostalCode);
                stringBuilder.Append(' ');
                stringBuilder.Append(this.customer.Address.Town);

                return stringBuilder.ToString();
            }
        }

       
    }
}
