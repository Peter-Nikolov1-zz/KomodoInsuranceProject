using KomodoProjectClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoProjectRepo
{
    //This is the Developer method repository
    //Make sure to include CRUD - Create Read Update Delete
    public class DeveloperRepo
    {
        protected readonly List<Developer> _listOfDevelopers = new List<Developer>();

        public void AddDeveloper(Developer developer)
        {

            _listOfDevelopers.Add(developer);
        }

        public List<Developer> CurrentDevelopers()
        {
            return _listOfDevelopers;
        }

        public Developer GetDeveloperByID(int id)
        {
            foreach (Developer developer in _listOfDevelopers)
            {
                if (developer.ID == id)
                {
                    return developer;
                }
            }
            return null;
        }

        public bool ModifyDevelopers(int uniqueID, Developer developer)
        {
            Developer developer1 = GetDeveloperByID(uniqueID);
            if (developer1 != null)
            {
                developer1.Name = developer.Name;
                developer1.Pluralsight = developer.Pluralsight;
                return true;
            }
            return false;
        }
        public bool RemoveDeveloper(Developer developer)
        {
            bool removeDeveloper = _listOfDevelopers.Remove(developer);
            return removeDeveloper;
        }
    }
}
