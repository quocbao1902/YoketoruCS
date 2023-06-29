namespace YoketoruCS
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTiltle = new Label();
            buttonStart = new Button();
            labelGameover = new Label();
            buttonTitle = new Button();
            labelClear = new Label();
            labelScore = new Label();
            labelHighScore = new Label();
            labelTimer = new Label();
            label3 = new Label();
            tempPlayer = new Label();
            label1 = new Label();
            labelCopyright = new Label();
            tempObstacle = new Label();
            tempItem = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // labelTiltle
            // 
            labelTiltle.AutoSize = true;
            labelTiltle.Font = new Font("Yu Gothic UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTiltle.Location = new Point(335, 135);
            labelTiltle.Name = "labelTiltle";
            labelTiltle.Size = new Size(162, 46);
            labelTiltle.TabIndex = 0;
            labelTiltle.Text = "よけとるCS";
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.Location = new Point(335, 237);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(162, 50);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "スタート!!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += button1_Click;
            // 
            // labelGameover
            // 
            labelGameover.AutoSize = true;
            labelGameover.Font = new Font("Yu Gothic UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelGameover.Location = new Point(332, 190);
            labelGameover.Name = "labelGameover";
            labelGameover.Size = new Size(165, 37);
            labelGameover.TabIndex = 2;
            labelGameover.Text = "GAME OVER";
            // 
            // buttonTitle
            // 
            buttonTitle.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTitle.Location = new Point(335, 300);
            buttonTitle.Name = "buttonTitle";
            buttonTitle.Size = new Size(162, 45);
            buttonTitle.TabIndex = 3;
            buttonTitle.Text = "タイトルへ";
            buttonTitle.UseVisualStyleBackColor = true;
            buttonTitle.Click += buttontitle_Click;
            // 
            // labelClear
            // 
            labelClear.AutoSize = true;
            labelClear.Font = new Font("Yu Gothic UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            labelClear.Location = new Point(350, 181);
            labelClear.Name = "labelClear";
            labelClear.Size = new Size(136, 46);
            labelClear.TabIndex = 4;
            labelClear.Text = "CLEAR!!";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Yu Gothic UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.Location = new Point(350, 9);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(110, 46);
            labelScore.TabIndex = 5;
            labelScore.Text = "00000";
            // 
            // labelHighScore
            // 
            labelHighScore.AutoSize = true;
            labelHighScore.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelHighScore.Location = new Point(325, 55);
            labelHighScore.Name = "labelHighScore";
            labelHighScore.Size = new Size(172, 28);
            labelHighScore.TabIndex = 6;
            labelHighScore.Text = "High Score: 00000";
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimer.Location = new Point(735, 409);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(53, 32);
            labelTimer.TabIndex = 8;
            labelTimer.Text = "000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 423);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 9;
            label3.Text = "(C) 2023 Nguyen Bao";
            // 
            // tempPlayer
            // 
            tempPlayer.AutoSize = true;
            tempPlayer.Font = new Font("源ノ角ゴシック Code JP H", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tempPlayer.Location = new Point(102, 212);
            tempPlayer.Name = "tempPlayer";
            tempPlayer.Size = new Size(104, 20);
            tempPlayer.TabIndex = 10;
            tempPlayer.Text = "(´｡• ω •｡`)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 292);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 11;
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.BackColor = Color.White;
            labelCopyright.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCopyright.Location = new Point(219, 322);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(34, 30);
            labelCopyright.TabIndex = 12;
            labelCopyright.Text = "☆";
            // 
            // tempObstacle
            // 
            tempObstacle.AutoSize = true;
            tempObstacle.Font = new Font("Yu Gothic UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tempObstacle.Location = new Point(143, 285);
            tempObstacle.Name = "tempObstacle";
            tempObstacle.Size = new Size(24, 20);
            tempObstacle.TabIndex = 13;
            tempObstacle.Text = "▽";
            // 
            // tempItem
            // 
            tempItem.AutoSize = true;
            tempItem.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tempItem.Location = new Point(103, 363);
            tempItem.Name = "tempItem";
            tempItem.Size = new Size(26, 21);
            tempItem.TabIndex = 14;
            tempItem.Text = "♡";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tempItem);
            Controls.Add(tempObstacle);
            Controls.Add(labelCopyright);
            Controls.Add(label1);
            Controls.Add(tempPlayer);
            Controls.Add(label3);
            Controls.Add(labelTimer);
            Controls.Add(labelHighScore);
            Controls.Add(labelScore);
            Controls.Add(labelClear);
            Controls.Add(buttonTitle);
            Controls.Add(labelGameover);
            Controls.Add(buttonStart);
            Controls.Add(labelTiltle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label labelTiltle;
        private Button buttonStart;
        private Label labelGameover;
        private Button buttonTitle;
        private Label labelClear;
        private Label labelScore;
        private Label labelHighScore;
        private Label labelTimer;
        private Label label3;
        private Label tempPlayer;
        private Label label1;
        private Label labelCopyright;
        private Label tempObstacle;
        private Label tempItem;
    }
}