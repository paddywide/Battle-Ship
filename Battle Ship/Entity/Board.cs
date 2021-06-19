using static Battle_Ship.Entity.Constants;

namespace Battle_Ship.Entity
{
    public class GameBoard
    {
        //the Point (0, 0) locates in the bottom left corner of the board
        public int[,] Board { get; private set; }
        public GameBoard()
        {
            Board = new int[Constants.BoardSize, Constants.BoardSize];
        }
        
        public bool ValidateShipPos(Point head, int direction, BattleShip ship)
        {
            if (direction == (int)ShipDirection.TailTowardsUp && (head.Y + ship.Size >= Constants.BoardSize))
                return false;

            if (direction == (int)ShipDirection.TailTowardsRight && (head.X + ship.Size >= Constants.BoardSize))
                return false;

            if (direction == (int)ShipDirection.TailTowardsDown && (head.Y - ship.Size < 0))
                return false;

            if (direction == (int)ShipDirection.TailTowardsLeft && (head.X - ship.Size < 0))
                return false;

            return true;
        }
        public bool IsOccupied(Point head, int direction, BattleShip ship)
        {
            if (direction == (int)ShipDirection.TailTowardsUp)
                return IsOccupied_TailTowardsUp(head, ship);

            if (direction == (int)ShipDirection.TailTowardsRight)
                return IsOccupied_TailTowardsRight(head, ship);

            if (direction == (int)ShipDirection.TailTowardsDown)
                return IsOccupied_TailTowardsDown(head, ship);

            if (direction == (int)ShipDirection.TailTowardsLeft)
                return IsOccupied_TailTowardsLeft(head, ship);

            return false;
        }
        private bool IsOccupied_TailTowardsUp(Point head, BattleShip ship)
        {
            for (int i = 0; i <= ship.Size; i++)
            {
                if (Board[head.X, head.Y + i] != 0)
                    return true;
            }
            return false;
        }
        private bool IsOccupied_TailTowardsRight(Point head, BattleShip ship)
        {
            for (int i = 0; i <= ship.Size; i++)
            {
                if (Board[head.X + i, head.Y] != 0)
                    return true;
            }
            return false;
        }
        private bool IsOccupied_TailTowardsDown(Point head, BattleShip ship)
        {
            for (int i = 0; i <= ship.Size; i++)
            {
                if (Board[head.X, head.Y - i] != 0)
                    return true;
            }
            return false;
        }
        private bool IsOccupied_TailTowardsLeft(Point head, BattleShip ship)
        {
            for (int i = 0; i <= ship.Size; i++)
            {
                if (Board[head.X - i, head.Y] != 0)
                    return true;
            }
            return false;
        }

        private void PlaceShip_sub(Point head, int direction, BattleShip ship)
        {
            if (direction == (int)ShipDirection.TailTowardsUp)
            {
                for (int i = 0; i <= ship.Size; i++)
                {
                    Board[head.X, head.Y + i] = ship.ID;
                }
            }

            if (direction == (int)ShipDirection.TailTowardsRight)
            {
                for (int i = 0; i <= ship.Size; i++)
                {
                    Board[head.X + i, head.Y ] = ship.ID;
                }
            }

            if (direction == (int)ShipDirection.TailTowardsDown)
            {
                for (int i = 0; i <= ship.Size; i++)
                {
                    Board[head.X, head.Y - i] = ship.ID;
                }
            }

            if (direction == (int)ShipDirection.TailTowardsLeft)
            {
                for (int i = 0; i <= ship.Size; i++)
                {
                    Board[head.X - i, head.Y] = ship.ID;
                }
            }
        }

        public bool PlaceShip(Point head, int direction, BattleShip ship)
        {
            if (!ValidateShipPos(head, direction, ship))
                return false;

            if (IsOccupied(head, direction, ship))
                return false;

            PlaceShip_sub(head, direction, ship);

            return true;
        }

        public int ToBeAttack(Point boomPoint, out int hitShipId)
        {
            if (Board[boomPoint.X, boomPoint.Y] != 0)
            {
                hitShipId = Board[boomPoint.X, boomPoint.Y];
                Board[boomPoint.X, boomPoint.Y] = 0;
                return (int)AttackStatus.HitBattleShip;
            }

            hitShipId = 0;
            return (int)AttackStatus.Miss;
        }

    }
}
