namespace Battleships.Lib.Models
{
    public class Coordinate
    {
        public int Position { get; }

        internal Coordinate(int position)
        {
            Position = position;
        }
    }
}
