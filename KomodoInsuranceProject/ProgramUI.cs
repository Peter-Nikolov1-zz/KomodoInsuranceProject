using KomodoProjectClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceProject
{
    public class ProgramUI
    {
        public void Run()
        {
            MainMenu();
        }

        public void MainMenu()
        {
            bool keepRunningMenu = true;
            while (keepRunningMenu)

                Console.WriteLine("Welcome! \n" +
                "Please select what you would like to do: \n" +
                "1. Add Developer \n" +
                "2. Remove Developer \n" +
                "3. Add Multiple Developers \n" +
                "4. Modify Developers");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //take the user to another menu that displays all current developers, add option and return menu
                    break;
                case "2":
                    //take the user to another menu that displays all current developers, remove option return menu
                    break;
                case "3":
                    //take the user to another menu that displays all current developers but has tips on what to do and a return menu 
                    break;
                case "4":
                    //Take the user to another menu that allows them to modify the pluralsight option
                    break;
                default:
                    Console.WriteLine("Please make a valid selection.");
                    break;
            }
            Console.ReadKey();
        }
        public void AddDeveloper()
        {
            Developer newDeveloper = new Developer();
            Console.WriteLine("Please provide the name of the new Developer:");
            newDeveloper.Name = Console.ReadLine();

            

            Console.WriteLine("Has the Developer access Pluralsight?");
            newDeveloper.Pluralsight = Console.ReadLine();
        }

    }
}
