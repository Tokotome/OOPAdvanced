﻿//Your totalitarian dystopian society suffers a shortage of food, so many rebels appear.Extend the code from your previous task with new functionality to solve this task.
//Define a class Rebel which has a name, age and group(string), names are unique - there will never be 2 Rebels/Citizens or a Rebel and Citizen with the same name.
//Define an interface IBuyer which defines a method BuyFood() and a integer property Food.Implement the IBuyer interface in the Citizen and Rebel class, both Rebels 
//and Citizens start with 0 food, when a Rebel buys food his Food increases by 5, when a Citizen buys food his Food increases by 10.
//On the first line of the input you will receive an integer N - the number of people, on each of the next N lines you will receive information in one of the following 
//formats “<name> <age> <id> <birthdate>” for a Citizen or “<name> <age><group>” for a Rebel.After the N lines until the command “End” is received, you will receive 
//names of people who bought food, each on a new line.Note that not all names may be valid, in case of an incorrect name - nothing should happen.
//On the only line of output you should print the total amount of food purchased.


namespace FoodShortage
{
    using System;
    using System.Collections.Generic;
    class FoodShortage
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();
                string[] parameters = input.Split(' ');
                if (parameters.Length == 4)
                {

                }
            }
        }
    }

    public interface IBuyer
    {
        int Food { get; }
        void BuyFood(int food);
    }

    public class Citizen : IBuyer
    {
        public string Name { get; }
        public int Age { get; }
        public string ID { get; }
        public string Birthdate { get; }

        public int Food { get; }

        public Citizen(int Food)
        {
            this.Food = 0;
        }

        public void BuyFood(int food)
        {
        }

    }

    public class Rebel : IBuyer
    {
        public string Name { get; }
        public int Age { get; }
        public string Group { get; }


        public int Food { get; }

        public Rebel(int Food)
        {
            this.Food = 0;
        }

        public void BuyFood(int food)
        {
        }

    }
}