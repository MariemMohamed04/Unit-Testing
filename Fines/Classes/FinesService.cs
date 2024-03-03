using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Console.Fines.Abstractions;

namespace UnitTesting.Console.Fines.Classes
{
    public class FinesService
    {
        private readonly IFineRepository _finesRepository;
        private readonly IEmailService _emailService;
        private readonly ISmsService _smsService;

        public FinesService(IEmailService emailService, ISmsService smsService, IFineRepository finesRepository)
        {
            _finesRepository = finesRepository;
            _emailService = emailService;
            _smsService = smsService;
        }

        public void HandleFine(int id, int amount)
        {
            // 1
            _finesRepository.AddFine(id, amount);

            // 2
            var email = _finesRepository.GetEmail(id);
            _emailService.SendEmail(email, "Hello", "You have a new fine");

            //3
            var mobile = _finesRepository.GetMobile(id);
            _smsService.SendSms(mobile, "You have a new fine");
        }
    }
}
