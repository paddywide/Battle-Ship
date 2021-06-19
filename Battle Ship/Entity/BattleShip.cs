using System;

namespace Battle_Ship.Entity
{
    public class BattleShip
    {
        private int id;
        private int size;
        public int Status { get; set; }
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                //in game board, we use 0 to indicate empty slot.
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid value. Battleship bas to be greater than 0");
                }
            }
        }

        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                if (value > 0 && value <= Constants.BoardSize)
                {
                    size = value;
                }
                else 
                {
                    throw new ArgumentOutOfRangeException("Invalid value. Battleship size has be to smaller or equal than " + Constants.BoardSize.ToString());
                }
            }
        }

        public BattleShip(int id, int size)
        {
            ID = id;
            Size = size;
        }
    }
}
