﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameConsoleApplication
{
    class Thing
    {
        public Point Position;

        public Thing(int x, int y)
        {
            Position = new Point(x, y);
        }
    }
}
