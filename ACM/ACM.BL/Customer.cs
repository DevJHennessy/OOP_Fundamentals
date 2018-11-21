using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }

        public static int InstanceCount { get; set; }

        //Using the propful tab tab shortcut:
        private string _firstName;

        public string FirstName
        {
            //Leave out the get to define a write-only property.
            get { return _firstName; }
            //Leave out the set to define a read-only property.
            set { _firstName = value; }
        }

        //Using prop tab tab for an auto-implemented property:
        //This still creates a backing field so that you still have the encapsulation.
        //This is only for properties that you do not need code in the get or set block.
        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }

            return isValid;
        }



    }
}
