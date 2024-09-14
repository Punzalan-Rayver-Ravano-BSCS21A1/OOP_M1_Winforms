using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal static class InventoryManager
    {
        static List<Person> people = new List<Person>();
     

        public static List<Person> GetItems()
        {
            // Create a list of objects
          
            people.Add(new Person { ID = 1, Name = "John Doe" });
            people.Add(new Person { ID = 2, Name = "Jane Smith" });
            return people;
        }
    }
}
