//You have a business - manufacturing cell phones.But you have no software developers, so you call your friends and ask 
//them to help you create a cell phone software.They agree and you start working on the project.The project consists of 
//one main model - a Smartphone.Each of your smartphones should have functionalities of calling other phones and browsing
//in the world wide web.
//Your friends are very busy, so you decide to write the code on your own. Here is the mandatory assignment:
//You should have a model - Smartphone and two separate functionalities which your smartphone has - to call other phones 
//and to browse in the world wide web. You should end up with one class and two interfaces.
//Input
//The input comes from the console. It will hold two lines:
//First line: phone numbers to call (String), separated by spaces.
//Second line: sites to visit(String), separated by spaces.

namespace Telephony
{

    using System;

    public interface ICallable
    {
        string CallANumber(string number);
    }

    public interface IBrowsable
    {
        string BrowseAWebsite(string url);
    }

    public class Smartphone : IBrowsable, ICallable
    {
        private string model;

        public Smartphone(string model)
        {
            this.model = model;
        }

        public string BrowseAWebsite(string url)
        {
            bool validURL = true;
            for (int i = 0; i < url.Length; i++)
            {
                if (char.IsDigit(url[i]))
                {
                    validURL = false;
                }
            }
            if (!validURL)
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}!";
        }
        public string CallANumber(string number)
        {
            bool validNumber = true;
            for (int i = 0; i < number.Length; i++)
            {
                if (!char.IsDigit(number[i]))
                {
                    validNumber = false;
                }
            }
            if (!validNumber)
            {
                return "Invalid number!";
            }

            return $"Calling... {number}";
        }


    }

    public class Telephony
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            Smartphone InputSmartphone = new Smartphone("Samsung");
            foreach (var phoneNumber in phoneNumbers)
            {
                Console.WriteLine(InputSmartphone.CallANumber(phoneNumber));
            }
            foreach (var url in urls)
            {
                Console.WriteLine(InputSmartphone.BrowseAWebsite(url));
            }
        }
    }
}
