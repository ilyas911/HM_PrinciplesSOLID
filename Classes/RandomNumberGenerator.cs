﻿using HW_PrinciplesSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_PrinciplesSOLID.Classes
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        private Random _random = new Random();
        public int Generate(int min, int max)
        {
            return _random.Next(min, max + 1);
        }
    }
}
