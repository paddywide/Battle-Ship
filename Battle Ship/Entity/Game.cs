namespace Battle_Ship.Entity
{
    public class Game
    {
        public Player PlayerA { get; }
        public Player PlayerB { get; }

        public Game(Player playerOne, Player playerTwo)
        {
            PlayerA = playerOne;
            PlayerB = playerTwo;
        }

        public bool PlaceShip(Point head, int direction, BattleShip ship, Player player)
        {
            return player.PlaceShip(head, direction, ship);
        }
        public int Attack(Point boomPoint, Player defender)
        {
            int shipId;
            return defender.ToBeAttack(boomPoint, out shipId);
        }
    }
}
