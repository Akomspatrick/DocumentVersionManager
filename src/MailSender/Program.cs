using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Reflection;
using System.Text;

using MailSender; //add EASendMail namespace
namespace mysendemail
{
    class Program
    {
        static void Main(string[] args)
        {
            int theport = 587;
            string sender = "Software Engr";

            string msg = "Testing mail sending using gmail";
            string subject = "Send From Gmail";
            string towhom = "";
            string toaddress = "";

            string thepassword = "";
            string thehost = "smtp.gmail.com";

            string fromAddress = "";


            string thepassword1 = "";
            string fromUser1 = "";
            string to1 = "";
            string officehost = "smtp.office365.com";
            string subject1 = "Send From hotmail";
            string msg1 = "Testing mail sending using hotmail";
            string sender1 = "Software Engr-hotmail";
            string towhom1 = "";

            string pass2 = "";

            // string to2 = "";
            //SendUsingOffice365.sendmail(fromUser1, officehost, theport, thepassword1, toaddress, msg1, subject1, sender1, towhom1);

            string thepassword2 = "";
            string fromUser2 = "";
            string to2 = "";

            string subject2 = "l";
            string msg2 = "";
            string sender2 = "";
            string towhom2 = "";


            SendUsingOffice365.sendmail(fromUser2, officehost, theport, thepassword2, toaddress, msg2, subject2, sender2, towhom2);
            // SendMailUsingOutLook.Send(fromUser, to, pass);

            //MAIL   GeneralClass.sendmailwtAttachment("Admin@polyibadan.edu.ng", "smtp.gmail.com", 587, "polyibadan", entity.EmailAddress,  msg, "FILLED APPLICATION FORM","Admissions", entity.Surname + " " + entity.Middlename + " " + entity.Firstname, Appprintout,"Filled_Form");

            // SendUsingGSmtp.sendmail(fromAddress, thehost, theport, thepassword, toaddress, msg, subject, sender, towhom);

            Console.WriteLine("Done..........................");
            Console.ReadLine();
        }


    }
}