using Battleships.Lib.Controllers.Interfaces;
using Battleships.Lib.Models;

namespace Battleships.Lib.Controllers
{
    public class GameController : IGameController
    {
        public Player PlayerA { get; }
        public Player PlayerB { get; }

        public GameController()
        {
            PlayerA = new Player();
            PlayerB = new Player();
        }

        public void Setup()
        {
            throw new NotImplementedException();
        }
    }
}
