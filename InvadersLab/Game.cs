﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace InvadersLab
{
    public class Game
    {
        private Random random;
        private Rectangle boundaries;
        private Stars stars;

        public Game(Random random, Rectangle clientRectangle)
        {
            // TODO: Complete member initialization
            this.random = random;
            this.boundaries = clientRectangle;
            stars = new Stars(random, clientRectangle);
        }

        public object Size { get { return boundaries.Size; } }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Black, 300), boundaries);
            stars.Draw(g);
        }

        public void Twinkle()
        {
            stars.Twinkle();
        }
    }
}
