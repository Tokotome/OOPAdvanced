//It is a well known fact that people celebrate birthdays, it is also known that some people also celebrate their pets birthdays.
//Extend the program from your task "Border control" to add birthdates to citizens and include a class Pet, pets have a name and 
//a birthdate.Encompass repeated functionality into interfaces and implement them in your classes.
//You will receive from the console an unknown amount of lines until the command “End” is received, each line will contain 
//information in one of the following formats “Citizen<name> <age> <id> <birthdate>” for citizens, “Robot<model> <id>” for 
//robots or “Pet<name> <birthdate>” for pets.After the end command on the next line you will receive a single number representing
//a specific year, your task is to print all birthdates (of both citizens and pets) in that year in the format 
//day/month/year(the order of printing doesn’t matter).


namespace BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;



    class BirthdayCelebrations
    {
        static void Main(string[] args)
        {
            List<IBirthday> outputBirthdays = new List<IBirthday>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] parameters = input.Split();
                string type = parameters[0];
                switch (type.ToLower())
                {
                    case "citizen":
                        string personName = parameters[1];
                        int age = int.Parse(parameters[2]);
                        string ID = parameters[3];
                        string birthday = parameters[4];
                        Person citizen = new Person(personName, age, ID, birthday);
                        outputBirthdays.Add(citizen);
                        break;
                    case "robot":
                        break;
                    case "pet":
                        string dogName = parameters[1];
                        string birthdate = parameters[2];
                        Pet pet = new Pet(dogName, birthdate);
                        outputBirthdays.Add(pet);
                        break;
                }
                input = Console.ReadLine();
            }
            string inputYear = Console.ReadLine();
            foreach (var birthdayObject in outputBirthdays)
            {
                if (birthdayObject.ValidDate(inputYear))
                {
                    Console.WriteLine(birthdayObject.Birthdate);
                }
            }
        }

        public interface IBirthday
        {
            string Birthdate { get; }

            bool ValidDate(string givenYear);
        }

        public interface ITemplatable
        {
            string ID { get; }
            string ModelName { get; }

            bool validCitizen(string fakeEndID);
        }

        public class Citizen : ITemplatable
        {
            public string ID { get; }
            public string ModelName { get; }

            public Citizen(string modelName, string id)
            {
                this.ModelName = modelName;
                this.ID = id;
            }

            public bool validCitizen(string fakeEndID)
            {
                if (this.ID.EndsWith(fakeEndID))
                {
                    return false;
                }
                return true;
            }
        }

        public class Person : Citizen, IBirthday
        {
            public int Age { get; }
            public string Birthdate { get; }
            public bool ValidDate(string givenYear)
            {
                if (this.Birthdate.EndsWith(givenYear))
                {
                    return true;
                }
                return false;
            }

            public Person(string modelName, int age, string id, string birthdate) : base(modelName, id)
            {
                this.Birthdate = birthdate;
                this.Age = age;
            }
        }

        public class Robot : Citizen
        {
            public string ID { get; }
            public string ModelName { get; }

            public Robot(string modelName, string id) : base(modelName, id)
            {
            }
        }

        public class Pet : IBirthday
        {
            public string Name { get; }
            public string Birthdate { get; }
            public bool ValidDate(string givenYear)
            {

                if (this.Birthdate.EndsWith(givenYear))
                {
                    return true;
                }
                return false;
            }

            public Pet(string name, string birthdate)
            {
                this.Name = name;
                this.Birthdate = birthdate;
            }
        }
    }
}
