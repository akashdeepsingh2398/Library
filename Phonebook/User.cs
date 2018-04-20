using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Phonebook
{
	public class User
	{
		public String name;
		public String address;
        public List<PhoneNumbers> phoneNumbers = new List<PhoneNumbers>();


		public User(String name, List<PhoneNumbers> phoneNumbers)
		{
			this.phoneNumbers = phoneNumbers;
			this.name = name;

		}
		public User(String name, List<PhoneNumbers> phoneNumbers, String address)
		{

			this.phoneNumbers = phoneNumbers;
			this.name = name;
			this.address = address;
		}

		public String UserName
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		public List<PhoneNumbers> UserNumber
		{
			get
			{
				return phoneNumbers;
			}
			
		}
        public void AddPhoneNumber(PhoneNumbers number ){

            phoneNumbers.Add(number);
        }
        public void DeleteNumber(PhoneNumbers number){

            phoneNumbers.Remove(number);
        }
        public String UserAddress
        {
            get{
                return address;
            }
            set{
                address = value;
            }
        }

	}
}
