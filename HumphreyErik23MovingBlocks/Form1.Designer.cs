namespace HumphreyErik23MovingBlocks
{
    partial class frmMovingBlocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovingBlocks));
            this.picHero = new System.Windows.Forms.PictureBox();
            this.picChips = new System.Windows.Forms.PictureBox();
            this.tmrScore = new System.Windows.Forms.Timer(this.components);
            this.tmrFires = new System.Windows.Forms.Timer(this.components);
            this.picFire1 = new System.Windows.Forms.PictureBox();
            this.picFire2 = new System.Windows.Forms.PictureBox();
            this.picFire4 = new System.Windows.Forms.PictureBox();
            this.picFire3 = new System.Windows.Forms.PictureBox();
            this.picFire5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFire1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFire2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFire4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFire3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFire5)).BeginInit();
            this.SuspendLayout();
            // 
            // picHero
            // 
            this.picHero.BackColor = System.Drawing.Color.Transparent;
            this.picHero.Image = ((System.Drawing.Image)(resources.GetObject("picHero.Image")));
            this.picHero.InitialImage = ((System.Drawing.Image)(resources.GetObject("picHero.InitialImage")));
            this.picHero.Location = new System.Drawing.Point(54, 262);
            this.picHero.Name = "picHero";
            this.picHero.Size = new System.Drawing.Size(52, 106);
            this.picHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHero.TabIndex = 0;
            this.picHero.TabStop = false;
            // 
            // picChips
            // 
            this.picChips.BackColor = System.Drawing.Color.Transparent;
            this.picChips.Image = global::HumphreyErik23MovingBlocks.Properties.Resources.chips;
            this.picChips.Location = new System.Drawing.Point(640, 52);
            this.picChips.Name = "picChips";
            this.picChips.Size = new System.Drawing.Size(76, 86);
            this.picChips.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picChips.TabIndex = 1;
            this.picChips.TabStop = false;
            // 
            // tmrScore
            // 
            this.tmrScore.Interval = 1000;
            this.tmrScore.Tick += new System.EventHandler(this.tmrScore_Tick);
            // 
            // tmrFires
            // 
            this.tmrFires.Interval = 10;
            this.tmrFires.Tick += new System.EventHandler(this.tmrFires_Tick);
            // 
            // picFire1
            // 
            this.picFire1.BackColor = System.Drawing.Color.Transparent;
            this.picFire1.Image = global::HumphreyErik23MovingBlocks.Properties.Resources.fireRed;
            this.picFire1.Location = new System.Drawing.Point(293, 12);
            this.picFire1.Name = "picFire1";
            this.picFire1.Size = new System.Drawing.Size(58, 76);
            this.picFire1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFire1.TabIndex = 2;
            this.picFire1.TabStop = false;
            // 
            // picFire2
            // 
            this.picFire2.BackColor = System.Drawing.Color.Transparent;
            this.picFire2.Image = global::HumphreyErik23MovingBlocks.Properties.Resources.fireRed;
            this.picFire2.Location = new System.Drawing.Point(213, 335);
            this.picFire2.Name = "picFire2";
            this.picFire2.Size = new System.Drawing.Size(58, 76);
            this.picFire2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFire2.TabIndex = 3;
            this.picFire2.TabStop = false;
            // 
            // picFire4
            // 
            this.picFire4.BackColor = System.Drawing.Color.Transparent;
            this.picFire4.Image = global::HumphreyErik23MovingBlocks.Properties.Resources.fireGreen;
            this.picFire4.Location = new System.Drawing.Point(468, 106);
            this.picFire4.Name = "picFire4";
            this.picFire4.Size = new System.Drawing.Size(58, 76);
            this.picFire4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFire4.TabIndex = 4;
            this.picFire4.TabStop = false;
            // 
            // picFire3
            // 
            this.picFire3.BackColor = System.Drawing.Color.Transparent;
            this.picFire3.Image = global::HumphreyErik23MovingBlocks.Properties.Resources.fireBlue;
            this.picFire3.Location = new System.Drawing.Point(370, 178);
            this.picFire3.Name = "picFire3";
            this.picFire3.Size = new System.Drawing.Size(58, 76);
            this.picFire3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFire3.TabIndex = 5;
            this.picFire3.TabStop = false;
            // 
            // picFire5
            // 
            this.picFire5.BackColor = System.Drawing.Color.Transparent;
            this.picFire5.Image = global::HumphreyErik23MovingBlocks.Properties.Resources.fireGreen;
            this.picFire5.Location = new System.Drawing.Point(468, 188);
            this.picFire5.Name = "picFire5";
            this.picFire5.Size = new System.Drawing.Size(58, 76);
            this.picFire5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFire5.TabIndex = 6;
            this.picFire5.TabStop = false;
            // 
            // frmMovingBlocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(804, 423);
            this.Controls.Add(this.picFire5);
            this.Controls.Add(this.picFire3);
            this.Controls.Add(this.picFire4);
            this.Controls.Add(this.picFire2);
            this.Controls.Add(this.picFire1);
            this.Controls.Add(this.picChips);
            this.Controls.Add(this.picHero);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMovingBlocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erik Humphrey\'s Quest for Chips";
            this.Load += new System.EventHandler(this.frmMovingBlocks_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMovingBlocks_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMovingBlocks_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFire1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFire2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFire4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFire3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFire5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHero;
        private System.Windows.Forms.PictureBox picChips;
        private System.Windows.Forms.Timer tmrScore;
        private System.Windows.Forms.Timer tmrFires;
        private System.Windows.Forms.PictureBox picFire1;
        private System.Windows.Forms.PictureBox picFire2;
        private System.Windows.Forms.PictureBox picFire4;
        private System.Windows.Forms.PictureBox picFire3;
        private System.Windows.Forms.PictureBox picFire5;
    }
}

