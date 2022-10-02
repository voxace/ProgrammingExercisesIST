using System;
using System.Collections.Generic;

namespace ProgrammingExercisesIST
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private bool _isSitting;
        private int _steps;

        public Person(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _isSitting = true;
            _steps = 0;
        }

        public void ChangeName(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public void ChangeNamePrompt()
        {
            Console.WriteLine($"Name is currently {this._firstName} {this._lastName}, enter new name.");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            _firstName = firstName;
            _lastName = lastName;
        }

        public void Walk(int steps)
        {
            if (_isSitting)
            {
                Console.WriteLine("You can't walk while you are sitting");
            }
            else
            {
                Console.WriteLine($"{_firstName} {_lastName} just walked {steps} steps");
                _steps += steps;
            }
        }

        public void Birthday()
        {
            _age++;
        }

        public void PrintInfo()
        {
            if (_isSitting)
            {
                Console.WriteLine($"{_firstName} {_lastName} is {_age} years old, is currently sitting " +
                                  $"and has taken {_steps} steps.");
            }
            else
            {
                Console.WriteLine($"{_firstName} {_lastName} is {_age} years old, is currently standing " +
                                  $"and has taken {_steps} steps.");
            }
        }

        public void Sit()
        {
            if (_isSitting)
            {
                Console.WriteLine($"{_firstName} {_lastName} is already sitting");
            }
            else
            {
                _isSitting = true;
            }
        }

        public void Stand()
        {
            if (_isSitting)
            {
                _isSitting = false;
            }
            else
            {
                Console.WriteLine($"{_firstName} {_lastName} is already standing");
            }
        }
    }
}
