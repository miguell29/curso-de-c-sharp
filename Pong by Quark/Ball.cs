﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Ball
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Ball(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
