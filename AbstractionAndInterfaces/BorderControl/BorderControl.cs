//It’s the future, you’re the ruler of a totalitarian dystopian society inhabited by citizens and robots, since you’re 
//afraid of rebellions you decide to implement strict control of who enters your city.Your soldiers check the Ids of 
//everyone who enters and leaves.
//You will receive from the console an unknown amount of lines until the command “End” is received, on each line there 
//will be the information for either a citizen or a robot who tries to enter your city in the format “<name> <age> <id>” 
//for citizens and “<model> <id>” for robots.After the end command on the next line you will receive a single number 
//representing the last digits of fake ids, all citizens or robots whose Id ends with the specified digits must be detained.
//The output of your program should consist of all detained Ids each on a separate line (the order of printing doesn’t matter).


namespace BorderControl
{

    using System;
    using System.Collections.Generic;
    class BorderControl
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();

            string line = Console.ReadLine();
            while (!line.Equals("End"))
            {
                string[] parameters = line.Split(' ');

                if (parameters.Length == 3)
                {
                    var person = new Citizen.Person(parameters[0], int.Parse(parameters[1]), parameters[2]);
                    citizens.Add(person);
                }

                else if (parameters.Length == 2)
                {
                    var robot = new Citizen.Robot(parameters[0], parameters[1]);
                    citizens.Add(robot);
                }
                line = Console.ReadLine();
            }

            string fakeIDEnding = Console.ReadLine();

            foreach (var citizen in citizens)
            {
                if (!citizen.validCitizen(fakeIDEnding))
                {
                    Console.WriteLine(citizen.ID);
                }
            }
        }
    }

    public interface ITemplatable
    {
        string ID { get; }
        string Name { get; }

        bool validCitizen(string fakeEndID);
    }

    public class Citizen : ITemplatable
    {
        public string ID { get; }
        public string Name { get; }


        public Citizen(string name, string id)
        {
            this.Name = name;
            this.ID = id;
            ;
        }

        public bool validCitizen(string fakeEndID)
        {
            if (this.ID.EndsWith(fakeEndID))
            {
                return false;
            }
            return true;
        }

        public class Person : Citizen
        {
            public int Age { get; }

            public Person(string model, int age, string id)
                : base(model, id)
            {
                this.Age = age;
            }
        }

        public class Robot : Citizen
        {
            public string ID { get; }
            public string Model { get; }

            public Robot(string model, string id)
                : base(model, id)
            {
            }
        }
    }
}

