namespace BoxField.Screens
{
    partial class MainScreen
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
            this.startButton = new System.Windows.Forms.Label();
            this.highscoreButton = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Red;
            this.startButton.Location = new System.Drawing.Point(404, 169);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(72, 31);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            // 
            // highscoreButton
            // 
            this.highscoreButton.AutoSize = true;
            this.highscoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreButton.Location = new System.Drawing.Point(375, 235);
            this.highscoreButton.Name = "highscoreButton";
            this.highscoreButton.Size = new System.Drawing.Size(151, 31);
            this.highscoreButton.TabIndex = 6;
            this.highscoreButton.Text = "Highscores";
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(417, 301);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(59, 31);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.highscoreButton);
            this.Controls.Add(this.startButton);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(900, 500);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startButton;
        private System.Windows.Forms.Label highscoreButton;
        private System.Windows.Forms.Label exitButton;
    }
}
