﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    class Person
    {
        public string firstName;
        public string surname;
        public int age;

        public override string ToString()
        {
            return $"Person: firstName = {firstName}, surname = {surname}, age = {age}";
        }
    }
}
