namespace Battleships.Lib.Models
{
    public class Grid
    {
        public IReadOnlyCollection<Coordinate> Coordinates { get; }

        internal Grid()
        {
            Coordinates = Initialize();
        }

        private IReadOnlyCollection<Coordinate> Initialize()
        {
            var coordinateCount = 100;
            var coordinates = new List<Coordinate>();

            for (int i = 0; i < coordinateCount; i++)
            {
                coordinates.Add(new(i));
            }
            return coordinates;
        }
    }
}