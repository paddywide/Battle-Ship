using System;

namespace Battle_Ship.Entity
{
    public class Point
    {
        private int x;
        public int y;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value >= 0 && value < Constants.BoardSize)
                {
                    x = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Coordinates X should be >= 0 and < than " + Constants.BoardSize.ToString());
                }
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value >= 0 && value < Constants.BoardSize)
                {
                    y = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Coordinates Y should be >= 0 and < than " + Constants.BoardSize.ToString());
                }
            }
        }
        public Point (int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
