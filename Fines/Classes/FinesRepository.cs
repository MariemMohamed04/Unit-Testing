using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Console.Fines.Abstractions;

namespace UnitTesting.Console.Fines.Classes
{
    public class FinesRepository : IFineRepository
    {
        public void AddFine(int id, int amount)
        {
            // some code to add to db
            System.Console.WriteLine("Fine was added to db");
        }

        public string GetEmail(int id)
        {
            // some code to get email
            System.Console.WriteLine("Actual query was run on db (Email)");
            return "";
        }

        public string GetMobile(int id)
        {
            // some code to get mobile
            System.Console.WriteLine("Actual query was run on db (Mobile)");
            return "";
        }
    }
}
