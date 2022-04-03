
namespace Tetris
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.gameClock = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputClock = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.gameStats = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_controls = new System.Windows.Forms.Label();
            this.lb_currentSong = new System.Windows.Forms.Label();
            this.lb_highScore = new System.Windows.Forms.Label();
            this.num_levelChoose = new System.Windows.Forms.NumericUpDown();
            this.panel_levelChoose = new System.Windows.Forms.Panel();
            this.lb_levelChoose = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_scoreboard = new System.Windows.Forms.Label();
            this.pb_btn_info = new System.Windows.Forms.PictureBox();
            this.pb_btn_scoreboard = new System.Windows.Forms.PictureBox();
            this.panel_highscore = new System.Windows.Forms.Panel();
            this.btn_submit = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_levelChoose)).BeginInit();
            this.panel_levelChoose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_btn_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_btn_scoreboard)).BeginInit();
            this.panel_highscore.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameClock
            // 
            this.gameClock.Tick += new System.EventHandler(this.gameClock_Tick);
            // 
            // label1
            // 
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DOWN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "RIGHT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(784, 741);
            this.display.TabIndex = 0;
            this.display.TabStop = false;
            this.display.Paint += new System.Windows.Forms.PaintEventHandler(this.display_Paint);
            // 
            // label3
            // 
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "LEFT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // inputClock
            // 
            this.inputClock.Interval = 50;
            this.inputClock.Tick += new System.EventHandler(this.inputClock_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(431, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Up";
            this.label5.Visible = false;
            // 
            // gameStats
            // 
            this.gameStats.BackColor = System.Drawing.Color.Cyan;
            this.gameStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStats.Location = new System.Drawing.Point(29, 173);
            this.gameStats.Name = "gameStats";
            this.gameStats.Size = new System.Drawing.Size(153, 173);
            this.gameStats.TabIndex = 6;
            this.gameStats.Text = "Score\r\n0\r\nLevel\r\n0\r\nLines\r\n0";
            this.gameStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameStats.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBorder);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(48, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(638, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "WIDER";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(638, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "HIGHER";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(655, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // lb_controls
            // 
            this.lb_controls.AutoSize = true;
            this.lb_controls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lb_controls.Location = new System.Drawing.Point(500, 277);
            this.lb_controls.Name = "lb_controls";
            this.lb_controls.Padding = new System.Windows.Forms.Padding(5);
            this.lb_controls.Size = new System.Drawing.Size(212, 442);
            this.lb_controls.TabIndex = 11;
            this.lb_controls.Text = resources.GetString("lb_controls.Text");
            this.lb_controls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_controls.Visible = false;
            this.lb_controls.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBorder);
            // 
            // lb_currentSong
            // 
            this.lb_currentSong.AutoSize = true;
            this.lb_currentSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_currentSong.Location = new System.Drawing.Point(57, 401);
            this.lb_currentSong.Name = "lb_currentSong";
            this.lb_currentSong.Padding = new System.Windows.Forms.Padding(4);
            this.lb_currentSong.Size = new System.Drawing.Size(101, 28);
            this.lb_currentSong.TabIndex = 12;
            this.lb_currentSong.Text = "Now playing\r\n";
            this.lb_currentSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_currentSong.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBorder);
            // 
            // lb_highScore
            // 
            this.lb_highScore.AutoSize = true;
            this.lb_highScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lb_highScore.Location = new System.Drawing.Point(528, 223);
            this.lb_highScore.Name = "lb_highScore";
            this.lb_highScore.Padding = new System.Windows.Forms.Padding(4);
            this.lb_highScore.Size = new System.Drawing.Size(113, 32);
            this.lb_highScore.TabIndex = 13;
            this.lb_highScore.Text = "High Score";
            this.lb_highScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_highScore.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBorder);
            // 
            // num_levelChoose
            // 
            this.num_levelChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.num_levelChoose.Location = new System.Drawing.Point(124, 11);
            this.num_levelChoose.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.num_levelChoose.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_levelChoose.Name = "num_levelChoose";
            this.num_levelChoose.Size = new System.Drawing.Size(63, 26);
            this.num_levelChoose.TabIndex = 14;
            this.num_levelChoose.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel_levelChoose
            // 
            this.panel_levelChoose.BackColor = System.Drawing.Color.Cyan;
            this.panel_levelChoose.Controls.Add(this.lb_levelChoose);
            this.panel_levelChoose.Controls.Add(this.btn_start);
            this.panel_levelChoose.Controls.Add(this.num_levelChoose);
            this.panel_levelChoose.Location = new System.Drawing.Point(262, 325);
            this.panel_levelChoose.Name = "panel_levelChoose";
            this.panel_levelChoose.Size = new System.Drawing.Size(200, 90);
            this.panel_levelChoose.TabIndex = 15;
            // 
            // lb_levelChoose
            // 
            this.lb_levelChoose.AutoSize = true;
            this.lb_levelChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lb_levelChoose.Location = new System.Drawing.Point(8, 12);
            this.lb_levelChoose.Name = "lb_levelChoose";
            this.lb_levelChoose.Size = new System.Drawing.Size(116, 24);
            this.lb_levelChoose.TabIndex = 16;
            this.lb_levelChoose.Text = "Starting level";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_start.Location = new System.Drawing.Point(11, 45);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(176, 35);
            this.btn_start.TabIndex = 15;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(58, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // lb_scoreboard
            // 
            this.lb_scoreboard.AutoSize = true;
            this.lb_scoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lb_scoreboard.Location = new System.Drawing.Point(237, 190);
            this.lb_scoreboard.Name = "lb_scoreboard";
            this.lb_scoreboard.Padding = new System.Windows.Forms.Padding(5);
            this.lb_scoreboard.Size = new System.Drawing.Size(119, 34);
            this.lb_scoreboard.TabIndex = 19;
            this.lb_scoreboard.Text = "Scoreboard";
            this.lb_scoreboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_scoreboard.Visible = false;
            this.lb_scoreboard.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBorder);
            // 
            // pb_btn_info
            // 
            this.pb_btn_info.BackColor = System.Drawing.Color.Cyan;
            this.pb_btn_info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_btn_info.BackgroundImage")));
            this.pb_btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_btn_info.Location = new System.Drawing.Point(737, 694);
            this.pb_btn_info.Name = "pb_btn_info";
            this.pb_btn_info.Size = new System.Drawing.Size(35, 35);
            this.pb_btn_info.TabIndex = 26;
            this.pb_btn_info.TabStop = false;
            this.pb_btn_info.Click += new System.EventHandler(this.pb_btn_info_Click);
            // 
            // pb_btn_scoreboard
            // 
            this.pb_btn_scoreboard.BackColor = System.Drawing.Color.Cyan;
            this.pb_btn_scoreboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_btn_scoreboard.BackgroundImage")));
            this.pb_btn_scoreboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_btn_scoreboard.Location = new System.Drawing.Point(12, 694);
            this.pb_btn_scoreboard.Name = "pb_btn_scoreboard";
            this.pb_btn_scoreboard.Size = new System.Drawing.Size(35, 35);
            this.pb_btn_scoreboard.TabIndex = 27;
            this.pb_btn_scoreboard.TabStop = false;
            this.pb_btn_scoreboard.Click += new System.EventHandler(this.pb_btn_scoreboard_Click);
            // 
            // panel_highscore
            // 
            this.panel_highscore.BackColor = System.Drawing.Color.Cyan;
            this.panel_highscore.Controls.Add(this.label11);
            this.panel_highscore.Controls.Add(this.tb_name);
            this.panel_highscore.Controls.Add(this.btn_submit);
            this.panel_highscore.Location = new System.Drawing.Point(240, 421);
            this.panel_highscore.Name = "panel_highscore";
            this.panel_highscore.Size = new System.Drawing.Size(222, 111);
            this.panel_highscore.TabIndex = 28;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_submit.Location = new System.Drawing.Point(6, 67);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(210, 35);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_name.Location = new System.Drawing.Point(6, 35);
            this.tb_name.MaxLength = 30;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(210, 26);
            this.tb_name.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.Location = new System.Drawing.Point(36, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "Enter your name";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 741);
            this.Controls.Add(this.panel_highscore);
            this.Controls.Add(this.pb_btn_scoreboard);
            this.Controls.Add(this.pb_btn_info);
            this.Controls.Add(this.lb_scoreboard);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel_levelChoose);
            this.Controls.Add(this.lb_highScore);
            this.Controls.Add(this.lb_currentSong);
            this.Controls.Add(this.lb_controls);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gameStats);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            this.Activated += new System.EventHandler(this.Game_Activated);
            this.Deactivate += new System.EventHandler(this.Game_Deactivate);
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_levelChoose)).EndInit();
            this.panel_levelChoose.ResumeLayout(false);
            this.panel_levelChoose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_btn_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_btn_scoreboard)).EndInit();
            this.panel_highscore.ResumeLayout(false);
            this.panel_highscore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gameClock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox display;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer inputClock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label gameStats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_controls;
        private System.Windows.Forms.Label lb_currentSong;
        private System.Windows.Forms.Label lb_highScore;
        private System.Windows.Forms.NumericUpDown num_levelChoose;
        private System.Windows.Forms.Panel panel_levelChoose;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lb_levelChoose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_scoreboard;
        private System.Windows.Forms.PictureBox pb_btn_info;
        private System.Windows.Forms.PictureBox pb_btn_scoreboard;
        private System.Windows.Forms.Panel panel_highscore;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_submit;
    }
}

