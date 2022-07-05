using Battleships.Lib.Models.Ships;

namespace Battleships.Lib.Models
{
    public class Player
    {
        public Grid Grid { get; }
        public IReadOnlyCollection<Ship> Ships { get; }

        internal Player()
        {
            Grid = new();
            Ships = new List<Ship>()
            {
                new Carrier(),
                new Battleship(),
                new Cruiser(),
                new Submarine(),
                new Destroyer()
            };
        }
    }
}
