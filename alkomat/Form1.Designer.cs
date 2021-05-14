namespace alkomat
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.beer = new System.Windows.Forms.Label();
            this.wine = new System.Windows.Forms.Label();
            this.vodka = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.promil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(416, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "You have drunk:";
            // 
            // beer
            // 
            this.beer.AutoSize = true;
            this.beer.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.beer.Location = new System.Drawing.Point(416, 111);
            this.beer.Name = "beer";
            this.beer.Size = new System.Drawing.Size(78, 69);
            this.beer.TabIndex = 2;
            this.beer.Text = "Beer: ";
            // 
            // wine
            // 
            this.wine.AutoSize = true;
            this.wine.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wine.Location = new System.Drawing.Point(416, 159);
            this.wine.Name = "wine";
            this.wine.Size = new System.Drawing.Size(80, 69);
            this.wine.TabIndex = 3;
            this.wine.Text = "Wine: ";
            // 
            // vodka
            // 
            this.vodka.AutoSize = true;
            this.vodka.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vodka.Location = new System.Drawing.Point(416, 205);
            this.vodka.Name = "vodka";
            this.vodka.Size = new System.Drawing.Size(87, 69);
            this.vodka.TabIndex = 4;
            this.vodka.Text = "Vodka:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.Location = new System.Drawing.Point(531, 343);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 69);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Save";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlText;
            this.progressBar1.Location = new System.Drawing.Point(355, 415);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(433, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // promil
            // 
            this.promil.AutoSize = true;
            this.promil.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.promil.ForeColor = System.Drawing.Color.Red;
            this.promil.Location = new System.Drawing.Point(531, 274);
            this.promil.Name = "promil";
            this.promil.Size = new System.Drawing.Size(41, 69);
            this.promil.TabIndex = 7;
            this.promil.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.promil);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.vodka);
            this.Controls.Add(this.wine);
            this.Controls.Add(this.beer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label beer;
        private System.Windows.Forms.Label wine;
        private System.Windows.Forms.Label vodka;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label promil;
    }
}