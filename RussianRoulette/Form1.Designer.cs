using System.Windows.Forms;

namespace RussianRoulette
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
            this.ShootHead = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.ShootAway = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShootHead
            // 
            this.ShootHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ShootHead.Font = new System.Drawing.Font("Sitka Small", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootHead.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ShootHead.Location = new System.Drawing.Point(894, 15);
            this.ShootHead.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ShootHead.Name = "ShootHead";
            this.ShootHead.Size = new System.Drawing.Size(149, 98);
            this.ShootHead.TabIndex = 0;
            this.ShootHead.Text = "Head shoot";
            this.ShootHead.UseVisualStyleBackColor = false;
            this.ShootHead.Click += new System.EventHandler(this.ShootHead_Click);
            // 
            // Spin
            // 
            this.Spin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Spin.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Spin.Location = new System.Drawing.Point(246, 76);
            this.Spin.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(111, 49);
            this.Spin.TabIndex = 1;
            this.Spin.Text = "Spin";
            this.Spin.UseVisualStyleBackColor = false;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // Load
            // 
            this.Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Load.Location = new System.Drawing.Point(248, 15);
            this.Load.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(109, 49);
            this.Load.TabIndex = 2;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // ShootAway
            // 
            this.ShootAway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ShootAway.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootAway.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ShootAway.Location = new System.Drawing.Point(750, 15);
            this.ShootAway.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ShootAway.Name = "ShootAway";
            this.ShootAway.Size = new System.Drawing.Size(138, 98);
            this.ShootAway.TabIndex = 3;
            this.ShootAway.Text = "Shoot Away";
            this.ShootAway.UseVisualStyleBackColor = false;
            this.ShootAway.Click += new System.EventHandler(this.ShootAway_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.BackColor = System.Drawing.Color.Yellow;
            this.PlayAgain.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain.ForeColor = System.Drawing.Color.Red;
            this.PlayAgain.Location = new System.Drawing.Point(194, 364);
            this.PlayAgain.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(189, 77);
            this.PlayAgain.TabIndex = 7;
            this.PlayAgain.Text = "Play Again";
            this.PlayAgain.UseVisualStyleBackColor = false;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Yellow;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.btn_Exit.Location = new System.Drawing.Point(805, 354);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(189, 77);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1043, 501);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.ShootAway);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.ShootHead);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShootHead;
        private System.Windows.Forms.Button Spin;
        private new System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button ShootAway;
        private object form1;

        public object GetForm1()
        {
            return form1;
        }

        private void SetForm1(object value)
        {
            form1 = value;
        }

        public Form1(Button load)
        {
            Load = load;
        }
        private Button PlayAgain;
        private Button btn_Exit;
    }
}

