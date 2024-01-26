namespace Battleships;

partial class Battleships
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battleships));
        playerTile0 = new PictureBox();
        cpuTile0 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)playerTile0).BeginInit();
        ((System.ComponentModel.ISupportInitialize)cpuTile0).BeginInit();
        SuspendLayout();
        // 
        // playerTile0
        // 
        playerTile0.BackColor = Color.DeepSkyBlue;
        playerTile0.BackgroundImage = (Image)resources.GetObject("playerTile0.BackgroundImage");
        playerTile0.BackgroundImageLayout = ImageLayout.Stretch;
        playerTile0.BorderStyle = BorderStyle.FixedSingle;
        playerTile0.Location = new Point(37, 37);
        playerTile0.Margin = new Padding(4);
        playerTile0.Name = "playerTile0";
        playerTile0.Size = new Size(55, 55);
        playerTile0.TabIndex = 0;
        playerTile0.TabStop = false;
        playerTile0.Tag = "";
        // 
        // cpuTile0
        // 
        cpuTile0.BackColor = Color.DeepSkyBlue;
        cpuTile0.BackgroundImage = (Image)resources.GetObject("cpuTile0.BackgroundImage");
        cpuTile0.BackgroundImageLayout = ImageLayout.Stretch;
        cpuTile0.BorderStyle = BorderStyle.FixedSingle;
        cpuTile0.Location = new Point(867, 37);
        cpuTile0.Margin = new Padding(4);
        cpuTile0.Name = "cpuTile0";
        cpuTile0.Size = new Size(55, 55);
        cpuTile0.TabIndex = 1;
        cpuTile0.TabStop = false;
        cpuTile0.Tag = "";
        // 
        // Battleships
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(1538, 803);
        Controls.Add(playerTile0);
        Controls.Add(cpuTile0);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "Battleships";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Battleships";
        Load += Battleships_Load;
        ((System.ComponentModel.ISupportInitialize)playerTile0).EndInit();
        ((System.ComponentModel.ISupportInitialize)cpuTile0).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PictureBox playerTile0;
    private PictureBox cpuTile0;
}