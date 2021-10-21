using KomodoProjectClasses;
using KomodoProjectRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoInsuranceProject
{
    public class ProgramUI
    {
        private static DeveloperRepo _newDevRepo = new DeveloperRepo();

        public void Run()
        {
            SeedData();
            MainMenu();
        }
        public void SeedData()
        {
            Developer developer1 = new Developer
            {
                ID = 5948,
                Name = "Peter",
                Pluralsight = false
            };

            _newDevRepo.AddDeveloper(developer1);

            Developer developer2 = new Developer
            {
                ID = 1234,
                Name = "Taylor",
                Pluralsight = false
            };

            _newDevRepo.AddDeveloper(developer2);

            Developer developer3 = new Developer
            {
                ID = 4321,
                Name = "Patty",
                Pluralsight = true
            };

            _newDevRepo.AddDeveloper(developer3);

        }
        public void MainMenu()
        {
            bool keepRunningMenu = true;
            while (keepRunningMenu)
            {
                Console.Clear();
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
                        AddDeveloper();
                        //take the user to another menu that displays all current developers, add option and return menu
                        break;
                    case "2":
                        ShowAllDevelopers();
                        //take the user to another menu that displays all current developers, remove option return menu
                        break;
                    case "3":
                        //take the user to another menu that displays all current developers but has tips on what to do and a return menu 
                        break;
                    case "4":
                        ModifyDevelopers();
                        //Take the user to another menu that allows them to modify the pluralsight option
                        break;
                    default:
                        Console.WriteLine("Please make a valid selection.");
                        break;
                }
                Console.ReadKey();
            }
        }
        private static void AddDeveloper()
        {
            Developer newDeveloper = new Developer();
            Console.WriteLine("Please provide the name of the new Developer:");
            newDeveloper.Name = Console.ReadLine();

            Console.WriteLine("Please provide the ID of the new Developer:");
            string devID = Console.ReadLine();
            newDeveloper.ID = int.Parse(devID);
        }

        private static void ModifyDevelopers()
        {
            ShowAllDevelopers();
            Console.WriteLine("Please specify the ID of you would like to modify.");
            string devID = Console.ReadLine();
            int updatedID = int.Parse(devID);
            Developer developer = new Developer();
            Console.WriteLine("Does this Developer have access to Pluralsight? (Y or N)");
            string pluralSight = Console.ReadLine();
            if(pluralSight == "Y")
            {
                developer.Pluralsight = true;
            }
            else
            {
                developer.Pluralsight = false;
            }

            _newDevRepo.ModifyDevelopers(updatedID, developer);
        }

        private static void ShowAllDevelopers()
        {
            List<Developer> developerList = _newDevRepo.CurrentDevelopers();
            foreach(Developer developer in developerList)
            {
                Console.WriteLine($"{developer.Name} | {developer.ID} | {developer.Pluralsight} ");
            }
        }

    }
}
