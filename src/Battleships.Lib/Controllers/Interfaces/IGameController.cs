using Battleships.Lib.Models;

namespace Battleships.Lib.Controllers.Interfaces
{
    public interface IGameController
    {
        Player GetPlayerA();

        Player GetPlayerB();

        void Setup();
    }
}