using System;
namespace Phonebook
{
    public class PhoneNumbers
    {
        private Int64 number;
       

		public PhoneNumbers(Int64 number)
		{
			
			this.number = number;
		}



       public Int64 PhNumber
        {
            get{
                return number;
            }
            set{
                  number =value;
            }
        }



    }
}
