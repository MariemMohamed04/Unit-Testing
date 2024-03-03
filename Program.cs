// See https://aka.ms/new-console-template for more information
using UnitTesting.Console.Fines.Abstractions;
using UnitTesting.Console.Fines.Classes;

Console.WriteLine("Hello, World!");

// Apply DI on the remaining services
// Add Fake classes for the services
var finesRepository = new FinesRepository();
var smsService = new SmsService();
var outlookMailService = new OutlookEmailService();
var actualFinesService = new FinesService(outlookMailService, smsService, finesRepository);
actualFinesService.HandleFine(1, 100);

Console.WriteLine("*****");

var fakefinesRepository = new fakeRepository();
var fakesmsService = new FakeSmsService();
var fakeMailService = new FakeMailService();
var fakeFinesService = new FinesService(fakeMailService, fakesmsService, fakefinesRepository);
fakeFinesService.HandleFine(1, 100);

class FakeMailService : IEmailService
{
    public void SendEmail(string email, string title, string message)
    {
        Console.WriteLine("No actual mail was sent");
    }
}

class FakeSmsService : ISmsService
{
    public void SendSms(string mobile, string message)
    {
        Console.WriteLine("From Fake SMS");
    }
}

class fakeRepository : IFineRepository
{
    public void AddFine(int id, int amount)
    {
        Console.WriteLine("fake add to db");
    }
    public string GetEmail(int id)
    {
        Console.WriteLine("get fake mail");
        return "";
    }
    public string GetMobile(int id)
    {
        Console.WriteLine("get fake sms");
        return "";
    }
}