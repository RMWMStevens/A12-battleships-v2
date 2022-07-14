using Battleships.Lib.Controllers.Interfaces;
using Battleships.Lib.Models;

namespace Battleships.Lib.Controllers
{
    public class GameController : IGameController
    {
        private readonly Player playerA;
        private readonly Player playerB;

        public Player GetPlayerA() => playerA;

        public Player GetPlayerB() => playerB;

        public GameController()
        {
            playerA = new Player();
            playerB = new Player();
        }

        public void Setup()
        {
            throw new NotImplementedException();
        }
    }
}
