using Battleships.Lib.Models.Ships;

namespace Battleships.Lib.Models
{
    public class Player
    {
        public List<Ship> Ships { get; }

        public Player()
        {
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
