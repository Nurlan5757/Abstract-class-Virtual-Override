﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace.Models
{
    internal class Fish : ISwim
    {
        public int MaxSwimTime { get; set; } = -1;

        public void swim()
        {
            Console.WriteLine("Fish swim");
        }
    }
}
