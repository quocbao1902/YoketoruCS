﻿namespace YoketoruCS
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
            labelTiltle.Location = new Point(301, 135);
            labelTiltle.Name = "labelTiltle";
            labelTiltle.Size = new Size(162, 46);
            labelTiltle.TabIndex = 0;
            labelTiltle.Text = "よけとるCS";
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.Location = new Point(301, 234);
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
            labelGameover.Location = new Point(301, 194);
            labelGameover.Name = "labelGameover";
            labelGameover.Size = new Size(165, 37);
            labelGameover.TabIndex = 2;
            labelGameover.Text = "GAME OVER";
            // 
            // buttonTitle
            // 
            buttonTitle.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTitle.Location = new Point(301, 299);
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
            labelClear.Location = new Point(316, 188);
            labelClear.Name = "labelClear";
            labelClear.Size = new Size(136, 46);
            labelClear.TabIndex = 4;
            labelClear.Text = "CLEAR!!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}