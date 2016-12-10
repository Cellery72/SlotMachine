namespace SlotMachine
{
    partial class SlotMachineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlotMachineForm));
            this.SpinPictureBox = new System.Windows.Forms.PictureBox();
            this.Reel1PictureBox = new System.Windows.Forms.PictureBox();
            this.Reel2PictureBox = new System.Windows.Forms.PictureBox();
            this.Reel3PictureBox = new System.Windows.Forms.PictureBox();
            this.WinnerPaidLabel = new System.Windows.Forms.Label();
            this.BetLabel = new System.Windows.Forms.Label();
            this.TotalCreditsLabel = new System.Windows.Forms.Label();
            this.JackpotLabel = new System.Windows.Forms.Label();
            this.ResetPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reel1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reel2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reel3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SpinPictureBox
            // 
            this.SpinPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SpinPictureBox.Image = global::SlotMachine.Properties.Resources.spin;
            this.SpinPictureBox.Location = new System.Drawing.Point(390, 12);
            this.SpinPictureBox.Name = "SpinPictureBox";
            this.SpinPictureBox.Size = new System.Drawing.Size(60, 50);
            this.SpinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinPictureBox.TabIndex = 6;
            this.SpinPictureBox.TabStop = false;
            this.SpinPictureBox.Click += new System.EventHandler(this.SpinPictureBox_Click);
            // 
            // Reel1PictureBox
            // 
            this.Reel1PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Reel1PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reel1PictureBox.Location = new System.Drawing.Point(76, 256);
            this.Reel1PictureBox.Name = "Reel1PictureBox";
            this.Reel1PictureBox.Size = new System.Drawing.Size(82, 70);
            this.Reel1PictureBox.TabIndex = 7;
            this.Reel1PictureBox.TabStop = false;
            // 
            // Reel2PictureBox
            // 
            this.Reel2PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Reel2PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reel2PictureBox.Location = new System.Drawing.Point(188, 256);
            this.Reel2PictureBox.Name = "Reel2PictureBox";
            this.Reel2PictureBox.Size = new System.Drawing.Size(82, 70);
            this.Reel2PictureBox.TabIndex = 8;
            this.Reel2PictureBox.TabStop = false;
            // 
            // Reel3PictureBox
            // 
            this.Reel3PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Reel3PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Reel3PictureBox.Location = new System.Drawing.Point(302, 256);
            this.Reel3PictureBox.Name = "Reel3PictureBox";
            this.Reel3PictureBox.Size = new System.Drawing.Size(82, 70);
            this.Reel3PictureBox.TabIndex = 9;
            this.Reel3PictureBox.TabStop = false;
            // 
            // WinnerPaidLabel
            // 
            this.WinnerPaidLabel.BackColor = System.Drawing.Color.Transparent;
            this.WinnerPaidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerPaidLabel.ForeColor = System.Drawing.Color.Red;
            this.WinnerPaidLabel.Location = new System.Drawing.Point(289, 376);
            this.WinnerPaidLabel.Name = "WinnerPaidLabel";
            this.WinnerPaidLabel.Size = new System.Drawing.Size(95, 21);
            this.WinnerPaidLabel.TabIndex = 10;
            this.WinnerPaidLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BetLabel
            // 
            this.BetLabel.BackColor = System.Drawing.Color.Transparent;
            this.BetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetLabel.ForeColor = System.Drawing.Color.Red;
            this.BetLabel.Location = new System.Drawing.Point(200, 376);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(59, 21);
            this.BetLabel.TabIndex = 11;
            this.BetLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalCreditsLabel
            // 
            this.TotalCreditsLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalCreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCreditsLabel.ForeColor = System.Drawing.Color.Red;
            this.TotalCreditsLabel.Location = new System.Drawing.Point(72, 376);
            this.TotalCreditsLabel.Name = "TotalCreditsLabel";
            this.TotalCreditsLabel.Size = new System.Drawing.Size(102, 21);
            this.TotalCreditsLabel.TabIndex = 12;
            this.TotalCreditsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // JackpotLabel
            // 
            this.JackpotLabel.BackColor = System.Drawing.Color.Transparent;
            this.JackpotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JackpotLabel.ForeColor = System.Drawing.Color.Red;
            this.JackpotLabel.Location = new System.Drawing.Point(184, 164);
            this.JackpotLabel.Name = "JackpotLabel";
            this.JackpotLabel.Size = new System.Drawing.Size(102, 21);
            this.JackpotLabel.TabIndex = 13;
            this.JackpotLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResetPictureBox
            // 
            this.ResetPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ResetPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetPictureBox.BackgroundImage")));
            this.ResetPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ResetPictureBox.Location = new System.Drawing.Point(12, 3);
            this.ResetPictureBox.Name = "ResetPictureBox";
            this.ResetPictureBox.Size = new System.Drawing.Size(81, 69);
            this.ResetPictureBox.TabIndex = 14;
            this.ResetPictureBox.TabStop = false;
            this.ResetPictureBox.Click += new System.EventHandler(this.ResetPictureBox_Click);
            // 
            // SlotMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SlotMachine.Properties.Resources.slotmachine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(462, 533);
            this.ControlBox = false;
            this.Controls.Add(this.ResetPictureBox);
            this.Controls.Add(this.JackpotLabel);
            this.Controls.Add(this.TotalCreditsLabel);
            this.Controls.Add(this.BetLabel);
            this.Controls.Add(this.WinnerPaidLabel);
            this.Controls.Add(this.Reel3PictureBox);
            this.Controls.Add(this.Reel2PictureBox);
            this.Controls.Add(this.Reel1PictureBox);
            this.Controls.Add(this.SpinPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SlotMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            this.Load += new System.EventHandler(this.SlotMachineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reel1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reel2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reel3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox SpinPictureBox;
        private System.Windows.Forms.PictureBox Reel1PictureBox;
        private System.Windows.Forms.PictureBox Reel2PictureBox;
        private System.Windows.Forms.PictureBox Reel3PictureBox;
        private System.Windows.Forms.Label WinnerPaidLabel;
        private System.Windows.Forms.Label BetLabel;
        private System.Windows.Forms.Label TotalCreditsLabel;
        private System.Windows.Forms.Label JackpotLabel;
        private System.Windows.Forms.PictureBox ResetPictureBox;
    }
}