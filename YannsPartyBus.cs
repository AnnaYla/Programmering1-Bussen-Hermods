using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyBus22
{
    class Bus
    {

        Customer[] customerArray = new Customer[10];// field for array creation expression

        public void Run() //method that contains the menu and submenu
        {
            int display; // declaring an int var to be used for the switch case statement menu

            do //created a do while loop
            {
                Console.Clear();// this will clear command line 
                display_menu(); // calling the display method

                display = Convert.ToInt32(Console.ReadLine());// this var will hold the user input

                switch (display)
                {
                    case 1: buy_ticket(); break;
                    case 2:

                        Console.WriteLine("|---------------------------------|\n" +
                                          "|Ticket for ladies cost 1000 sek. |\n" +
                                          "|Ticket for mens cost 1500 sek. (men drink more beer)  |\n" +
                                          "|---------------------------------|\n");
                        Console.ReadKey(); // used so it does not automatically close
                        break;
                    case 3:

                        Console.WriteLine("|-----------------------------------------------------------------------|\n" +
                                          "|  16:00- 4:30 pm pm start of boarding.                                 |\n" +
                                          "|  16:30- 18:00 pm Off to Awesome Beach for a seafood buffet dinner     |\n" +
                                          "|  18:00- 20:00 pm Joyride Disco to Amazing Canyon View.                |\n" +
                                          "|  20:00- 22:00 pm karaoke time, sing all your hearts out               |\n" +
                                          "|  22:00-23:00 pm buffet evening snack and going home.                  |\n" +
                                          "|  16:30- 18:00 pm Off to Awesome Beach for a seafood buffet dinner     |\n" +
                                          "|-----------------------------------------------------------------------|\n");
                        Console.ReadKey(); //used so it does not automatically close
                        break;
                    case 4:
                        // here i created a second menu
                        {
                            int subMenu;// var for the sub menu
                            do // created a 2nd do while loop for the submenu
                            {
                                Console.Clear(); // clear the consol from the previous user choices
                                display_subMenu();// caling the method that contains the menu 
                                subMenu = Convert.ToInt32(Console.ReadLine());  //this var will hold the user input

                                switch (subMenu) // contains all the methods ,I have created that the project requires
                                {
                                    case 1: print_bus(); break;
                                    case 2: average_age(); break;
                                    case 3: max_age(); break;
                                    case 4: sortAge(); break;
                                    case 5: total_age(); break;
                                    case 6: find_age(); break;
                                    case 7: Console.WriteLine("Return to main menu."); break;
                                    default: Console.WriteLine("Please select from the menu. "); break;
                                }
                                break;// a break outside, let user come out from the submenu back to main menu

                            } while (subMenu != 0); // end of submenu, if user input zero it will become false
                                                    // and user will exit the program

                        }
                        Console.WriteLine("4. Party Bus Customer Info"); break;

                    case 5: Environment.Exit(0); return; // methos used to exit the program,
                                                         // the int 0 means the process was completed successfully
                   
                    default: Console.WriteLine("Please select from the menu."); break;
                }


            } while (display != 0); // in do while loop as long as condition is true
                                    // it will run till it become false

        } // end of run method

        //create a submenu
        public void display_subMenu()
        {
            Console.WriteLine("Select below on what you want to know. \n");
            Console.WriteLine("1. Print all Customers \n" +
                              "2. Total average age of Customers\n" +
                              "3. The oldest Customer\n" +
                              "4. Sort age of customers\n" +
                              "5. Sum of age of all passenger\n" +
                              "6. Search for a specific age of passenger\n" +
                              "7. Exit\n");
            Console.Write("Select option: ");
        } // end of submenu

        //create main menu method
        static void display_menu()
        {
            Console.WriteLine("Welcome to the best Party Bus in town \n" +
                               "You have a chance to rent our bus for your group.\n" +
                                "Maximun Capacity of the bus is 10 people.\n");
            Console.WriteLine("1. Buy a ticket \n" +
                              "2. Check ticket price\n" +
                              "3. Party Bus Schedule\n" +
                              "4. Party Bus Customer Info\n" +
                              "5. Exit\n");
            Console.Write("Select option: ");
        } // end menu method 

        public void buy_ticket() // method that holds all the elments in the array that user will input
        {
            Console.Clear();
            Console.WriteLine("--------- buy a ticket ---------");

            Customer[] customersArray = new Customer[10]; // i had to declare and initialize again because error occurs if I dont do it.
                                                          // I dont really know why it behaves like it does.

            for (int i = 0; i < customersArray.Length; i++) // using for loop to fill the array
            {
                customerArray[i] = new Customer(); // all elements will be stored in the customer object
                Console.WriteLine();
                Console.WriteLine("**** Ticket {0} ****", i + 1);

                Console.Write("Name: ");
                customerArray[i].Name = Console.ReadLine(); //saving name to name constructor 

                Console.Write("Age: ");
                customerArray[i].Age = Convert.ToInt32(Console.ReadLine()); //saving age in the age constructor

            }
        }

        // end of buy_ticket method

        public void print_bus() // prints the list of party bus customer 
        {
            Console.Clear();
            Console.WriteLine(" --------- Current Customers ---------- ");

            int i = 0;// declare and initialize var

            foreach (Customer person in customerArray)
            {
                Console.WriteLine(customerArray[i]);
                i++; 
            }
            Console.WriteLine("============================\n" +
                              "Press any key to continue...");
            Console.ReadKey(true);
        }


        public void total_age() // add total age of the customer
        {
            Console.Clear();
            Console.WriteLine("=== Total age ===");

            int sumAgeofCustomers = 0;// declare and initialize var to be used in the loop
            foreach (Customer person in customerArray)
            {
                sumAgeofCustomers += person.Age;
            }

            Console.WriteLine("The total age of the current customers is {0} years.", sumAgeofCustomers);
            Console.WriteLine("============================\n" +
                                          "Press any key to continue...");
            Console.ReadKey(true);
        }

        //Metoder för betyget C

        public void average_age() // average age of all customers
        {

            Console.Clear();
            Console.WriteLine("--------- Customers Average Age ----------");
            int numberofcustomers = 0;// declare and initialize
            int sumAgeofCustomers = 0;// the 2 var that will be used

            foreach (Customer person in customerArray)
            {
                sumAgeofCustomers += person.Age;
            }
            int average = numberofcustomers / customerArray.Length;
            

            Console.WriteLine("The average age of the current passengers is {0} .", sumAgeofCustomers / customerArray.Length);

            Console.WriteLine("============================\n" +
                              "Press any key to continue...");
            Console.ReadKey(true);
        }

        public void max_age() // the biggest int in the array 
        {


            Console.Clear();
            Console.WriteLine("--------- Oldest Customer Age ----------");

            // Find oldest passenger
            int i;
            int oldest = customerArray[0].Age;

            for (i = 1; i < customerArray.Length; i++)
            {

                if (customerArray[i].Age > oldest)
                {
                    oldest = customerArray[i].Age;
                }

            }

            Console.WriteLine("The oldest customer is " + oldest + "  years old.");



            Console.WriteLine("============================\n" +
                              "Press any key to continue...");
            Console.ReadKey(true);
        }

        public void find_age() // find specific age of customers in the array
        {
            Console.Clear();
            Console.WriteLine("--------- Passengers with specific age ---------");

            int findAge = 0;

            Console.WriteLine("What age do you want to find");
            findAge = Convert.ToInt32(Console.ReadLine());

            int numberOfmatch = 0;

            foreach (Customer person in customerArray)
            {
                if (person.Age == findAge)
                {
                    Console.WriteLine(person.Name + " is " + findAge + " years old.");
                    numberOfmatch++;
                }
            }

            if (numberOfmatch == 0)
            {
                Console.WriteLine("\nNo customer matched.");
            }
            else
            {
                Console.WriteLine("\nYou got {0} matched on your search.", numberOfmatch);
            }
            Console.WriteLine("============================\n" +
                              "Press any key to continue...");
            Console.ReadKey(true);

        }

        public void sortAge() // sort age in increasing way using array.Sort method
        {

            Console.Clear();
            Console.WriteLine("--------- Sort from youngest to oldest---------");

            Array.Sort(customerArray, (x, y) => x.Age.CompareTo(y.Age));

            Array.ForEach(customerArray, Console.WriteLine);

            Console.WriteLine("============================\n" +
                             "Press any key to continue...");
            Console.ReadKey(true);

        }

    }

    class Customer
    {// Data about passenger
        private string name; // im supposed to use it for encapsualtion                 
        private int age; // but for some reason it is not used and I dont understand why yet


        public string Name //constructor
        { get;set; }

        public int Age //constructor
        { get; set; }

        public Customer()
        {
            Name = null;
            Age = 0;
        }
        public override string ToString() // used so method will return string, /
                                          // useful in listing the elements in the array
        {
            string text = null;

            text += "\nName: " + Name;
            text += "\nAge: " + Age;

            return text;

        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var myBus = new Bus(); // create an object
            myBus.Run(); 
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }


}

