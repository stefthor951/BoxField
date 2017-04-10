﻿namespace BoxField
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.gameLoop = new System.Windows.Forms.Timer(this.components);
			this.scoreLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// gameLoop
			// 
			this.gameLoop.Enabled = true;
			this.gameLoop.Interval = 8;
			this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
			// 
			// scoreLabel
			// 
			this.scoreLabel.AutoSize = true;
			this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
			this.scoreLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoreLabel.Location = new System.Drawing.Point(30, 30);
			this.scoreLabel.Name = "scoreLabel";
			this.scoreLabel.Size = new System.Drawing.Size(124, 27);
			this.scoreLabel.TabIndex = 0;
			this.scoreLabel.Text = "Score : ";
			// 
			// GameScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.Controls.Add(this.scoreLabel);
			this.DoubleBuffered = true;
			this.Name = "GameScreen";
			this.Size = new System.Drawing.Size(900, 500);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
			this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label scoreLabel;
    }
}
