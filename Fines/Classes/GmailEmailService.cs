using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Console.Fines.Abstractions;

namespace UnitTesting.Console.Fines.Classes
{
    public class GmailEmailService : IEmailService
    {
        public void SendEmail(string email, string title, string message)
        {
            // some code to send mail
            System.Console.WriteLine("Actual mail was sent");
        }
    }
}
