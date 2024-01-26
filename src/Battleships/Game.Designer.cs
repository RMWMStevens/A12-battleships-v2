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
        playerTile00 = new PictureBox();
        cpuTile00 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)playerTile00).BeginInit();
        ((System.ComponentModel.ISupportInitialize)cpuTile00).BeginInit();
        SuspendLayout();
        // 
        // playerTile00
        // 
        playerTile00.BackColor = Color.DeepSkyBlue;
        playerTile00.BackgroundImage = (Image)resources.GetObject("playerTile00.BackgroundImage");
        playerTile00.BackgroundImageLayout = ImageLayout.Stretch;
        playerTile00.BorderStyle = BorderStyle.FixedSingle;
        playerTile00.Location = new Point(37, 37);
        playerTile00.Margin = new Padding(4);
        playerTile00.Name = "playerTile00";
        playerTile00.Size = new Size(55, 55);
        playerTile00.TabIndex = 0;
        playerTile00.TabStop = false;
        playerTile00.Tag = "";
        // 
        // cpuTile00
        // 
        cpuTile00.BackColor = Color.DeepSkyBlue;
        cpuTile00.BackgroundImage = (Image)resources.GetObject("cpuTile00.BackgroundImage");
        cpuTile00.BackgroundImageLayout = ImageLayout.Stretch;
        cpuTile00.BorderStyle = BorderStyle.FixedSingle;
        cpuTile00.Location = new Point(867, 37);
        cpuTile00.Margin = new Padding(4);
        cpuTile00.Name = "cpuTile00";
        cpuTile00.Size = new Size(55, 55);
        cpuTile00.TabIndex = 1;
        cpuTile00.TabStop = false;
        cpuTile00.Tag = "";
        // 
        // Battleships
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(1538, 803);
        Controls.Add(playerTile00);
        Controls.Add(cpuTile00);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "Battleships";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Battleships";
        Load += Battleships_Load;
        ((System.ComponentModel.ISupportInitialize)playerTile00).EndInit();
        ((System.ComponentModel.ISupportInitialize)cpuTile00).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PictureBox playerTile00;
    private PictureBox cpuTile00;
}