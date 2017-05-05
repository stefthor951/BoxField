namespace BoxField.Screens
{
    partial class LoseScreen
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
            this.scoreOutputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameText1 = new System.Windows.Forms.Label();
            this.nameText2 = new System.Windows.Forms.Label();
            this.nameText3 = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreOutputLabel
            // 
            this.scoreOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreOutputLabel.Location = new System.Drawing.Point(287, 260);
            this.scoreOutputLabel.Name = "scoreOutputLabel";
            this.scoreOutputLabel.Size = new System.Drawing.Size(327, 39);
            this.scoreOutputLabel.TabIndex = 3;
            this.scoreOutputLabel.Text = "Final Score:";
            this.scoreOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            this.label1.Visible = false;
            // 
            // nameText1
            // 
            this.nameText1.AutoSize = true;
            this.nameText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText1.Location = new System.Drawing.Point(338, 107);
            this.nameText1.Name = "nameText1";
            this.nameText1.Size = new System.Drawing.Size(75, 73);
            this.nameText1.TabIndex = 7;
            this.nameText1.Text = "A";
            // 
            // nameText2
            // 
            this.nameText2.AutoSize = true;
            this.nameText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText2.Location = new System.Drawing.Point(413, 107);
            this.nameText2.Name = "nameText2";
            this.nameText2.Size = new System.Drawing.Size(75, 73);
            this.nameText2.TabIndex = 8;
            this.nameText2.Text = "A";
            // 
            // nameText3
            // 
            this.nameText3.AutoSize = true;
            this.nameText3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText3.Location = new System.Drawing.Point(488, 107);
            this.nameText3.Name = "nameText3";
            this.nameText3.Size = new System.Drawing.Size(75, 73);
            this.nameText3.TabIndex = 9;
            this.nameText3.Text = "A";
            // 
            // restartButton
            // 
            this.restartButton.AutoSize = true;
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(91, 400);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(103, 31);
            this.restartButton.TabIndex = 10;
            this.restartButton.Text = "Restart";
            // 
            // menuButton
            // 
            this.menuButton.AutoSize = true;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(659, 400);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(146, 31);
            this.menuButton.TabIndex = 11;
            this.menuButton.Text = "Main Menu";
            // 
            // LoseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.nameText3);
            this.Controls.Add(this.nameText2);
            this.Controls.Add(this.nameText1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreOutputLabel);
            this.Name = "LoseScreen";
            this.Size = new System.Drawing.Size(900, 500);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoseScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LoseScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label scoreOutputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameText1;
        private System.Windows.Forms.Label nameText2;
        private System.Windows.Forms.Label nameText3;
        private System.Windows.Forms.Label restartButton;
        private System.Windows.Forms.Label menuButton;
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  