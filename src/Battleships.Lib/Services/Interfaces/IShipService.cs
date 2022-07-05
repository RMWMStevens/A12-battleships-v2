using Battleships.Lib.Models;
using Battleships.Lib.Models.Ships;

namespace Battleships.Lib.Services.Interfaces
{
    internal interface IShipService
    {
        void CalculatePossibleDirections(Ship ship, Grid grid);

        void PlaceShip(Ship ship, Grid grid);

        void ShowPossibleDirections(Ship ship, Grid grid);
    }
}