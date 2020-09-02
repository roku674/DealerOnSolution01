using System;

namespace DealerOnSolution1
{
    //raris and rovas
    public class Rover
    {
        char d;
        int x, y, val;
        char[] dir = { 'S', 'W', 'N', 'E' }; //cardinal directions
        static int maxX, maxY;
        bool inside = true;
        public Rover(int x, int y, char d)
        {
            this.x = x;
            this.y = y;
            this.d = d;

            switch (d)
            {
                case 'N': val = 2; break;
                case 'S': val = 0; break;
                case 'E': val = 3; break;
                case 'W': val = 1; break;
            }
        }
        public void analyze(char m)
        {
            switch (m)
            {
                case 'L': val--; break;
                case 'R': val++; break;
                case 'M': move(); break;
            }
            if (val == -1) val = dir.Length - 1;
            if (val == dir.Length) val = 0;

            this.d = dir[val];

        }
        public void move()
        {
            switch (this.d)
            {
                case 'N': this.y++; break;
                case 'E': this.x++; break;
                case 'S': this.y--; break;
                case 'W': this.x--; break;
            }
            if (this.x < 0 || this.y < 0 || this.x > maxX || this.y > maxY) this.inside = false;
        }
        
    }
}
