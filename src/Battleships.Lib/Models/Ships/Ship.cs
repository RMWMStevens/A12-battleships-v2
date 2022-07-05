namespace Battleships.Lib.Models.Ships
{
    public abstract class Ship
    {
        public int Size { get; }
        public List<int> Coordinates { get; } = new List<int>();

        public Ship(int size)
        {
            Size = size;
        }
    }
}
