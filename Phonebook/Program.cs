using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class MainClass
    {
       public static List<User> allUsers = new List<User>();
       public static List<PhoneNumbers> allPhoneNumbers = new List<PhoneNumbers>();
        
        
        public static void Main(string[] args)
        {
            Art();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("PRESS ENTER TO CONTINUE....");
            Console.ReadKey();
            Console.Clear();
            EnterChoice();

        }


        public static void Display(){

            Console.WriteLine("Press 1 = Add New Contact Number                        Press 2 = Delete Contact Number");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press 3 = Search Contacts in Phonebook by Name          Press 4 = Search Contacts in Phonebook by Numbers");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press 5 = See All Contact Names                         Press 6 = See all Contact Names with Numbers");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                                Press any key to EXIT        ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("PLEASE ENTER YOUR CHOICE : ");

        }

        public static void EnterChoice(){

            String condition = "49";
            Char con = condition.ElementAt(0);

            while (con>48 && con< 55)
            {
                Display();
                condition = Console.ReadLine();
                con = condition.ElementAt(0);

                if (con==49) //1
                {
                    NewUser();

					Console.Write("Do you want to add another Contact number y/n : ");
					String ar = Console.ReadLine();
					Console.WriteLine();

					if (ar == "y" || ar == "Y")
					{
                        con = (char)49;
					}
                }
                else if (con==50)  //2
                {
                    DeleteUser();

					Console.Write("Do you want to delete another Contact number y/n : ");
					String ar = Console.ReadLine();
					Console.WriteLine();

					if (ar == "y" || ar == "Y")
					{
						con = (char)50;
					}

                }
                else if(con == 51)   //3
                {
                    SearchName();
                }
				else if (con == 52)   //4
				{
                    SearchByNumbers();
				}
				else if (con == 53)   //5
				{
                    ContactNames();
                    Console.ReadKey();
				}
				else if (con == 54)   //6
				{
                    ContactNamesAnsNumbers();
                    Console.ReadKey();
				}

                Console.Clear();
            }

            Console.WriteLine("Thank you.....");
        }

        public static void SearchByNumbers(){

			Console.Write("Contact Number : ");
            Int64 name = Convert.ToInt64(Console.ReadLine());
			

			List<PhoneNumbers> p = new List<PhoneNumbers>();
			User us = new User("", p);
			bool k = false;

			foreach (User St in allUsers)
			{
                foreach (PhoneNumbers item in St.phoneNumbers)
                {
                    if (item.PhNumber.Equals(name))
					{
						k = true;
						us = St;

					}
                }


			}
			if (k == true)
			{
                Console.WriteLine();
                Console.WriteLine();
				Console.WriteLine("Name                 Phone Number                  Address   ");
				Console.WriteLine();
                Console.WriteLine();
				Console.Write(us.UserName + "            ");


				foreach (PhoneNumbers item in us.phoneNumbers)
				{
					Console.Write(item.PhNumber.ToString() + ",");
				}
				Console.WriteLine("        "+us.UserAddress);
			}
			else
			{
                Console.WriteLine();
				Console.WriteLine("This Contact does not Exist");
			}

			Console.ReadKey();


		}

		public static void DeleteUser()
		{

            Console.WriteLine();
			Console.Write("Name of the Contact to be deleted : ");
			String name = Console.ReadLine();
			name = name.ToUpper();
			Console.WriteLine();

			List<PhoneNumbers> p = new List<PhoneNumbers>();
			User us = new User("", p);

			bool k = false;

			foreach (User St in allUsers)
			{
				if (St.UserName.Contains(name))
				{
					k = true;
					us = St;

				}
			}

			if (k == true)
			{
				allUsers.Remove(us);
			}
			else
			{
                Console.WriteLine();
				Console.WriteLine("This Contact does not Exist");
			}

        }

        public static void ContactNames(){

            Console.WriteLine("        NAMES      ");
            Console.WriteLine();
            Console.WriteLine();
            foreach (User item in allUsers)
            {
                Console.WriteLine("       "+item.name);
            }
        }

        public static void ContactNamesAnsNumbers(){

            Console.WriteLine();
            Console.WriteLine();
			Console.WriteLine("        NAMES                   NUMBERS");
            Console.WriteLine();
            Console.WriteLine();
			foreach (User item in allUsers)
			{
				Console.Write("       " + item.name+ "      ");

                foreach (PhoneNumbers it in item.phoneNumbers)
                {
                    Console.Write(it.PhNumber.ToString()+ ", ");
                }
                Console.WriteLine();
            }
        }

        public static void SearchName(){

            Console.Write("Contact Name : ");
            String name = Console.ReadLine();
            name = name.ToUpper();

		    List<PhoneNumbers> p = new List<PhoneNumbers>();
			User us = new User("", p);
			bool k = false;

			foreach (User St in allUsers)
			{
				if (St.UserName.Contains(name))
				{
					k = true;
					us = St;

				}
			}
			if (k == true)
			{
                Console.WriteLine();
                Console.WriteLine("NAME                 PHONE NUMBER                   ADDRESS   ");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write(us.UserName + "            " );


                foreach (PhoneNumbers item in us.phoneNumbers)
                {
                    Console.Write(item.PhNumber.ToString() + ",");
                }
                Console.WriteLine("        " + us.UserAddress);
            }
			else
			{
                Console.WriteLine();
				Console.WriteLine("This Contact does not Exist");
                Console.WriteLine();
			}

            Console.ReadKey();


        }






        public static void NewUser(){

            Console.WriteLine();
            Console.Write("Contact Name : ");
            String name = Console.ReadLine();
            name = name.ToUpper();
            Console.WriteLine();

            List<PhoneNumbers> userNumb = new List<PhoneNumbers>();

			Console.Write("Contact Number : ");
            PhoneNumbers numb = new PhoneNumbers(Convert.ToInt64(Console.ReadLine()));
            userNumb.Add(numb);
			Console.WriteLine();

            Console.Write("Do you want to add more Number in this Contact Y/N : ");
            string cont = Console.ReadLine();

            while (cont == "Y" || cont == "y")
            {
                Console.Write("Contact Number : ");
				numb = new PhoneNumbers(Convert.ToInt64(Console.ReadLine()));
                Console.WriteLine();
				userNumb.Add(numb);
				

                Console.Write("Do you want to add more Number in this Contact Y/N : ");
                Console.WriteLine();
			    cont = Console.ReadLine();
            }

            Console.Write("Address : ");
            String addr = Console.ReadLine();
            Console.WriteLine();


            User user = new User(name,userNumb,addr);

            allUsers.Add(user);



        }
        public static void Art(){

Console.WriteLine("			_.===========================._             ");
Console.WriteLine("		 .'`  .-  - __- - - -- --__--- -.  `'.          ");
Console.WriteLine("	 __ / ,'`     _|--|_________|--|_     `'. \\    	 "   );
Console.WriteLine("                                                     ");
Console.WriteLine("	  / '--| ;    _.'\\ | '         ' | / '._    ; |     ");
Console.WriteLine("	 //   | |_.-' .-'.'    -  -- -    '.'-. '-._| |     ");
Console.WriteLine("	 (\\)   \\\"` _.-` /                     \\ `-._ `\" /   ");  
Console.WriteLine("	(\\)    `-`    /      .-------- -.      \\    `-`    ");
Console.WriteLine("    (\\)           |      || 1 || 2 || 3 ||      |    ");
Console.WriteLine("   (\\)            |      || 4 || 5 || 6 ||      |    "); 
Console.WriteLine("  (\\)             |      || 7 || 8 || 9 ||      |    "); 
Console.WriteLine(" (\\)           ___ |      || *|| 0 ||#||      |      "); 
Console.WriteLine(" (\\)          /.-- | '---------' |                   ");
Console.WriteLine("  (\\)        (\\)  |\\_ _  __ _   __ __/|              "); 
Console.WriteLine("(\\)        (\\)   |                       |           "); 
Console.WriteLine("(\\)_._._.__(\\) |                       |             ");
Console.WriteLine("(\\\\\\\\jgs\\\\\\)      '.___________________.'            ");
Console.WriteLine("'-' - '-'--'");
     
        }




    }
}
