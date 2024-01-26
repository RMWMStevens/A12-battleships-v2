using System.Media;

namespace Battleships;

public partial class Battleships : Form
{
    private const string PlayerTile = "playerTile";
    private const string CpuTile = "cpuTile";

    public Battleships()
    {
        InitializeComponent();
        playerGrid = LoadGrid(PlayerTile, PlayerGridClick!);
        cpuGrid = LoadGrid(CpuTile, CpuGridClick!);
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

    private void PlayerGridClick(object sender, EventArgs e)
    {
        PictureBox tile = (PictureBox)sender;

        if (gameStarted)
        {
            MessageBox.Show("Don't try to shoot your own ships, dummy!", "Wrong Side");
            return;
        }

        //if (selectedShip is Ship.None)
        //{
        //    if (btnStart.BackColor == Color.Black)
        //    {
        //        MessageBox.Show("You are currently in Spectator Mode! To play a new game, press RESET");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select a ship first!" + Environment.NewLine + Environment.NewLine + "This can also be done with the numbers 1, 2 and 3 on your keyboard!");
        //    }
        //}
        //else if (selectedShip is Ship.Airplane or Ship.Battleship or Ship.PatrolBoat)
        //{
        //    //InkBlue();
        //    //Calculate();
        //    //InkPath();
        //}
        //else
        //{
        //    if (TableA[iInUse].BackColor == Color.White || TableA[iInUse].BackColor == Color.FloralWhite || TableA[iInUse].BackColor == Color.GhostWhite || TableA[iInUse].BackColor == Color.WhiteSmoke)
        //    {
        //        DrawPath();
        //    }
        //}
    }

    private void CpuGridClick(object sender, EventArgs e)
    {
    
    }

    private PictureBox[,] LoadGrid(string name, Action<object?, EventArgs> clickEventHandler)
    {
        PictureBox[,] gridTiles = new PictureBox[10, 10];
        PictureBox gridTile = (PictureBox)Controls.Find(name + "00", true).First();
        Point location = gridTile.Location;
        int offset = 63;

        for (int y = 0; y < 10; y++)
        {
            for (int x = 0; x < 10; x++)
            {
                gridTiles[x, y] = x == 0 && y == 0 ? gridTile : ClonePictureBox(gridTile, name + x + y, offset * x, offset * y);
                gridTiles[x, y].Click += new EventHandler(clickEventHandler);
                Controls.Add(gridTiles[x, y]);
            }
        }

        return gridTiles;
    }

    private PictureBox ClonePictureBox(PictureBox source, string name, int offsetX, int offsetY) => new()
    {
        BackgroundImage = new Bitmap(source.BackgroundImage!),
        BorderStyle = source.BorderStyle,
        Location = new Point(source.Location.X + offsetX, source.Location.Y + offsetY),
        Name = name,
        Margin = source.Margin,
        Size = source.Size,
    };
}