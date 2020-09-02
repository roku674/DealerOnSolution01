using System;
using System.IO;

namespace DealerOnSolution1
{
    //raris and rovas
    public class Rover
    {
        char d;
        int x, y, value;
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
                case 'N': value = 2; break;
                case 'S': value = 0; break;
                case 'E': value = 3; break;
                case 'W': value = 1; break;
            }
        }
        public void analyze(char m)
        {
            switch (m)
            {
                case 'L': value--; break;
                case 'R': value++; break;
                case 'M': move(); break;
            }
            if (value == -1) value = dir.Length - 1;
            if (value == dir.Length) value = 0;

            this.d = dir[value];

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
