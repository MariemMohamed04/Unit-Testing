using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Console.Fines.Abstractions
{
    public interface IFineRepository
    {
        public void AddFine(int id, int amount);
        public string GetEmail(int id);
        public string GetMobile(int id);
    }
}
