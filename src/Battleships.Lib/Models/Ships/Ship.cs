namespace Battleships.Lib.Models.Ships
{
    public abstract class Ship
    {
        public int Size { get; }

        private IReadOnlyCollection<Coordinate> coordinates = new List<Coordinate>();
        public IReadOnlyCollection<Coordinate> Coordinates
        {
            get => coordinates;
            set
            {
                if (value.Count != Size) { throw new ApplicationException("Amount of coordinates does not match the ship size"); }
                coordinates = value;
            }
        }

        internal Ship(int size)
        {
            Size = size;
        }
    }
}
