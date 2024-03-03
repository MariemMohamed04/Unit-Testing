using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Console.Fines.Abstractions
{
    public interface ISmsService
    {
        public void SendSms(string mobile, string message);

    }
}
