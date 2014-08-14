namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.played = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.Label();
            this.Ties = new System.Windows.Forms.Label();
            this.Losses = new System.Windows.Forms.Label();
            this.Wins = new System.Windows.Forms.Label();
            this.dealerScore = new System.Windows.Forms.Label();
            this.labelComputer = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.deal = new System.Windows.Forms.Button();
            this.stand = new System.Windows.Forms.Button();
            this.hit = new System.Windows.Forms.Button();
            this.heading = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerPanel = new System.Windows.Forms.Panel();
            this.dealerPanel = new System.Windows.Forms.Panel();
            this.dealerCard2 = new System.Windows.Forms.PictureBox();
            this.dealerCard1 = new System.Windows.Forms.PictureBox();
            this.playerCard2 = new System.Windows.Forms.PictureBox();
            this.playerCard1 = new System.Windows.Forms.PictureBox();
            this.playerPic = new System.Windows.Forms.Panel();
            this.dealerPic = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // played
            // 
            this.played.AutoSize = true;
            this.played.Location = new System.Drawing.Point(666, 654);
            this.played.Name = "played";
            this.played.Size = new System.Drawing.Size(77, 13);
            this.played.TabIndex = 45;
            this.played.Text = "Games played:";
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Location = new System.Drawing.Point(550, 470);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(38, 13);
            this.playerScore.TabIndex = 44;
            this.playerScore.Text = "Score:";
            // 
            // Ties
            // 
            this.Ties.AutoSize = true;
            this.Ties.Location = new System.Drawing.Point(666, 604);
            this.Ties.Name = "Ties";
            this.Ties.Size = new System.Drawing.Size(30, 13);
            this.Ties.TabIndex = 43;
            this.Ties.Text = "Ties:";
            // 
            // Losses
            // 
            this.Losses.AutoSize = true;
            this.Losses.Location = new System.Drawing.Point(666, 551);
            this.Losses.Name = "Losses";
            this.Losses.Size = new System.Drawing.Size(43, 13);
            this.Losses.TabIndex = 42;
            this.Losses.Text = "Losses:";
            // 
            // Wins
            // 
            this.Wins.AutoSize = true;
            this.Wins.Location = new System.Drawing.Point(666, 496);
            this.Wins.Name = "Wins";
            this.Wins.Size = new System.Drawing.Size(34, 13);
            this.Wins.TabIndex = 41;
            this.Wins.Text = "Wins:";
            // 
            // dealerScore
            // 
            this.dealerScore.AutoSize = true;
            this.dealerScore.Location = new System.Drawing.Point(550, 98);
            this.dealerScore.Name = "dealerScore";
            this.dealerScore.Size = new System.Drawing.Size(38, 13);
            this.dealerScore.TabIndex = 40;
            this.dealerScore.Text = "Score:";
            // 
            // labelComputer
            // 
            this.labelComputer.AutoSize = true;
            this.labelComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputer.Location = new System.Drawing.Point(449, 89);
            this.labelComputer.Name = "labelComputer";
            this.labelComputer.Size = new System.Drawing.Size(75, 25);
            this.labelComputer.TabIndex = 34;
            this.labelComputer.Text = "Dealer";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.Location = new System.Drawing.Point(449, 458);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(73, 25);
            this.labelPlayer.TabIndex = 33;
            this.labelPlayer.Text = "Player";
            // 
            // deal
            // 
            this.deal.AutoSize = true;
            this.deal.Location = new System.Drawing.Point(328, 404);
            this.deal.Name = "deal";
            this.deal.Size = new System.Drawing.Size(100, 23);
            this.deal.TabIndex = 27;
            this.deal.Text = "DEAL";
            this.deal.UseVisualStyleBackColor = true;
            this.deal.Click += new System.EventHandler(this.deal_Click);
            // 
            // stand
            // 
            this.stand.AutoSize = true;
            this.stand.Location = new System.Drawing.Point(567, 404);
            this.stand.Name = "stand";
            this.stand.Size = new System.Drawing.Size(100, 23);
            this.stand.TabIndex = 26;
            this.stand.Text = "STAND";
            this.stand.UseVisualStyleBackColor = true;
            this.stand.Click += new System.EventHandler(this.stand_Click);
            // 
            // hit
            // 
            this.hit.AutoSize = true;
            this.hit.Location = new System.Drawing.Point(445, 404);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(100, 23);
            this.hit.TabIndex = 25;
            this.hit.Text = "HIT";
            this.hit.UseVisualStyleBackColor = true;
            this.hit.Click += new System.EventHandler(this.hit_Click);
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.BackColor = System.Drawing.Color.ForestGreen;
            this.heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.Color.Black;
            this.heading.Location = new System.Drawing.Point(322, 36);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(326, 33);
            this.heading.TabIndex = 24;
            this.heading.Text = "Big Ballers Black Jack";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // playerPanel
            // 
            this.playerPanel.Location = new System.Drawing.Point(328, 625);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(249, 123);
            this.playerPanel.TabIndex = 57;
            // 
            // dealerPanel
            // 
            this.dealerPanel.Location = new System.Drawing.Point(328, 260);
            this.dealerPanel.Name = "dealerPanel";
            this.dealerPanel.Size = new System.Drawing.Size(249, 123);
            this.dealerPanel.TabIndex = 58;
            // 
            // dealerCard2
            // 
            this.dealerCard2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.CardBack1;
            this.dealerCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dealerCard2.Location = new System.Drawing.Point(413, 131);
            this.dealerCard2.Name = "dealerCard2";
            this.dealerCard2.Size = new System.Drawing.Size(79, 123);
            this.dealerCard2.TabIndex = 56;
            this.dealerCard2.TabStop = false;
            // 
            // dealerCard1
            // 
            this.dealerCard1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.CardBack1;
            this.dealerCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dealerCard1.Location = new System.Drawing.Point(328, 131);
            this.dealerCard1.Name = "dealerCard1";
            this.dealerCard1.Size = new System.Drawing.Size(79, 123);
            this.dealerCard1.TabIndex = 55;
            this.dealerCard1.TabStop = false;
            // 
            // playerCard2
            // 
            this.playerCard2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.CardBack1;
            this.playerCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerCard2.Location = new System.Drawing.Point(413, 496);
            this.playerCard2.Name = "playerCard2";
            this.playerCard2.Size = new System.Drawing.Size(79, 123);
            this.playerCard2.TabIndex = 54;
            this.playerCard2.TabStop = false;
            // 
            // playerCard1
            // 
            this.playerCard1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.CardBack1;
            this.playerCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerCard1.Location = new System.Drawing.Point(328, 496);
            this.playerCard1.Name = "playerCard1";
            this.playerCard1.Size = new System.Drawing.Size(79, 123);
            this.playerCard1.TabIndex = 53;
            this.playerCard1.TabStop = false;
            // 
            // playerPic
            // 
            this.playerPic.AutoSize = true;
            this.playerPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playerPic.BackgroundImage")));
            this.playerPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerPic.Location = new System.Drawing.Point(151, 458);
            this.playerPic.Name = "playerPic";
            this.playerPic.Size = new System.Drawing.Size(140, 140);
            this.playerPic.TabIndex = 39;
            // 
            // dealerPic
            // 
            this.dealerPic.AutoSize = true;
            this.dealerPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dealerPic.BackgroundImage")));
            this.dealerPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dealerPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dealerPic.Location = new System.Drawing.Point(151, 89);
            this.dealerPic.Name = "dealerPic";
            this.dealerPic.Size = new System.Drawing.Size(140, 140);
            this.dealerPic.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 741);
            this.Controls.Add(this.dealerPanel);
            this.Controls.Add(this.playerPanel);
            this.Controls.Add(this.dealerCard2);
            this.Controls.Add(this.dealerCard1);
            this.Controls.Add(this.playerCard2);
            this.Controls.Add(this.playerCard1);
            this.Controls.Add(this.played);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.Ties);
            this.Controls.Add(this.Losses);
            this.Controls.Add(this.Wins);
            this.Controls.Add(this.dealerScore);
            this.Controls.Add(this.playerPic);
            this.Controls.Add(this.dealerPic);
            this.Controls.Add(this.labelComputer);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.deal);
            this.Controls.Add(this.stand);
            this.Controls.Add(this.hit);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label played;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label Ties;
        private System.Windows.Forms.Label Losses;
        private System.Windows.Forms.Label Wins;
        private System.Windows.Forms.Label dealerScore;
        private System.Windows.Forms.Panel playerPic;
        private System.Windows.Forms.Panel dealerPic;
        private System.Windows.Forms.Label labelComputer;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Button deal;
        private System.Windows.Forms.Button stand;
        private System.Windows.Forms.Button hit;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.PictureBox playerCard1;
        private System.Windows.Forms.PictureBox playerCard2;
        private System.Windows.Forms.PictureBox dealerCard1;
        private System.Windows.Forms.PictureBox dealerCard2;
        private System.Windows.Forms.Panel playerPanel;
        private System.Windows.Forms.Panel dealerPanel;

    }
}

