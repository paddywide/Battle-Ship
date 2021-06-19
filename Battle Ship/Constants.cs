namespace Battle_Ship.Entity
{
    public static class Constants
    {
        public const int BoardSize = 10;
        public enum ShipDirection
        {
            TailTowardsUp = 0,
            TailTowardsRight = 1,
            TailTowardsDown = 2,
            TailTowardsLeft = 3
        }
        public enum AttackStatus
        {
            Miss = 0,
            HitBattleShip = 1
        }
        public enum BattleShipHealthStatus
        {
            Good = 0,
            Sink = 1
        }
    }
}
