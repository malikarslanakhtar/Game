namespace Game
{
    partial class Form2
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
            this.lblFire = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LifeBar = new System.Windows.Forms.ProgressBar();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFire
            // 
            this.lblFire.AutoSize = true;
            this.lblFire.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFire.Location = new System.Drawing.Point(22, 9);
            this.lblFire.Name = "lblFire";
            this.lblFire.Size = new System.Drawing.Size(55, 21);
            this.lblFire.TabIndex = 0;
            this.lblFire.Text = "Fire: 0";
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDown.Location = new System.Drawing.Point(22, 40);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(72, 21);
            this.lblDown.TabIndex = 1;
            this.lblDown.Text = "Down: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Life:";
            // 
            // LifeBar
            // 
            this.LifeBar.Location = new System.Drawing.Point(314, 7);
            this.LifeBar.Name = "LifeBar";
            this.LifeBar.Size = new System.Drawing.Size(164, 23);
            this.LifeBar.TabIndex = 3;
            this.LifeBar.Value = 100;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // Player
            // 
            this.Player.Image = global::Game.Properties.Resources.Front;
            this.Player.Location = new System.Drawing.Point(26, 457);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(94, 83);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 4;
            this.Player.TabStop = false;
            this.Player.WaitOnLoad = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 561);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.LifeBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDown);
            this.Controls.Add(this.lblFire);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KEYDOWN);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KEYUP);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFire;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar LifeBar;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox Player;
    }
}