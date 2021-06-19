using Battle_Ship.Entity;
using static Battle_Ship.Entity.Constants;

namespace Battle_Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            Player alpha = new Player(1, "AlphaGo");
            Player lee = new Player(2, "Lee");
            BattleShip destroyer = new BattleShip(1, 3);

            Game gameOne = new Game(alpha, lee);
            gameOne.PlaceShip(new Point(0, 0), (int)ShipDirection.TailTowardsRight, destroyer, alpha);
            gameOne.PlaceShip(new Point(0, 5), (int)ShipDirection.TailTowardsRight, destroyer, lee);

            int status_alpha = gameOne.Attack(new Point(0, 0), lee);
            int status_lee = gameOne.Attack(new Point(0, 0), alpha);
            status_lee = gameOne.Attack(new Point(1, 0), alpha);
            status_lee = gameOne.Attack(new Point(2, 0), alpha);

            bool alphaGameStatus = alpha.IsLostTheGame();
            bool leeGameStatus = lee.IsLostTheGame();
            int a = 0;
        }
    }
}
