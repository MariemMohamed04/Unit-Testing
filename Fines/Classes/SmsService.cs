using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Console.Fines.Abstractions;

namespace UnitTesting.Console.Fines.Classes
{
    public class SmsService : ISmsService
    {
        public void SendSms(string mobile, string message)
        {
            // some code to send sms
            System.Console.WriteLine("Actual sms was sent");
        }
    }
}
