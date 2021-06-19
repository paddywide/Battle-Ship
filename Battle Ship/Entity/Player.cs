using static Battle_Ship.Entity.Constants;

namespace Battle_Ship.Entity
{
    public class Player
    {
        public int ID { get;}
        public string Name { get;}
        private int _battleShipSlotCount;
        private GameBoard _myBoard;
        public Player(int id, string name)
        {
            ID = id;
            Name = name;
            _battleShipSlotCount = 0;
            _myBoard = new GameBoard();
        }

        public bool PlaceShip(Point head, int direction, BattleShip ship)
        {
            bool stat = _myBoard.PlaceShip(head, direction, ship);
            if (stat)
                _battleShipSlotCount += ship.Size;

            return stat;
        }

        public int ToBeAttack(Point boomPoint, out int shipId)
        {
            int status = -1;
            status = _myBoard.ToBeAttack(boomPoint, out shipId);
            if (status == (int)AttackStatus.HitBattleShip)
                _battleShipSlotCount--;

            return status;
        }
        public bool IsLostTheGame()
        {
            if (_battleShipSlotCount <= 0)
                return true;

            return false;
        }
    }
}

