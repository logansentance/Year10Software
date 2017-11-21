﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Ronin", "Davis", 16);
            p.Sit();
            p.Stand();
            p.PrintInfo();
        }
    }
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private bool sitting;
        private int steps;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            sitting = true;
            steps = 0;

        }
        public void PrintInfo()
        {
            if (sitting)
            {
                Console.WriteLine($"{firstName} {lastName} is {age} years old, is currently sitting" + $"and has taken {steps} steps.");
            }
            else
            {
                Console.WriteLine($"{firstName} {lastName} is {age} years old, is currently standing" + $" and has taken {steps} steps.");
            }
        }
        public void Sit()
        {
            if (sitting)
            {
                Console.WriteLine($"{firstName} {lastName} is already sitting");
            }
            else
            {
                sitting = true;
            }

        }

        public void Stand()
        {
            if (sitting)
            {
                sitting = false;
            }
            else
            {
                Console.WriteLine($"{firstName} {lastName} is already standing");
            }

        }
    }
}
