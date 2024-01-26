namespace Battleships;

public partial class Battleships : Form
{
    public Battleships()
    {
        InitializeComponent();
        playerGrid = LoadGrid("playerTile0");
        cpuGrid = LoadGrid("cpuTile0");
    }

    readonly PictureBox[,] playerGrid;
    int playerMisses = 0;
    int playerHits = 0;

    readonly PictureBox[,] cpuGrid;
    int cpuMisses = 0;
    int cpuHits = 0;
    readonly List<int> cpuHitHistory = new List<int>();
    readonly Random random = new Random();

    // Battleships
    int airplaneCarriers = 1;
    int battleships = 3;
    int patrolBoats = 3;

    Ship selectedShip = Ship.None;

    bool gameStarted = false;
    int delay = 0;

    private void Battleships_Load(object sender, EventArgs e) { }

    private PictureBox[,] LoadGrid(string name)
    {
        PictureBox[,] gridTiles = new PictureBox[10, 10];
        PictureBox gridTile = (PictureBox)Controls.Find(name, true).First();
        Point location = gridTile.Location;
        int offset = 63;

        for (int y = 0; y < 10; y++)
        {
            for (int x = 0; x < 10; x++)
            {
                gridTiles[x, y] = x == 0 && y == 0 ? gridTile : ClonePictureBox(gridTile, offset * x, offset * y);

                Controls.Add(gridTiles[x, y]);
            }
        }

        return gridTiles;
    }

    private PictureBox ClonePictureBox(PictureBox source, int offsetX, int offsetY) => new()
    {
        BackgroundImage = new Bitmap(source.BackgroundImage!),
        Size = source.Size,
        Location = new Point(source.Location.X + offsetX, source.Location.Y + offsetY),
        BorderStyle = source.BorderStyle,
        Margin = source.Margin
    };
}