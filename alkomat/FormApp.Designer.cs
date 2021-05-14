namespace alkomat
{
    partial class FormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            this.body = new System.Windows.Forms.Label();
            this.mass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.beer = new System.Windows.Forms.TextBox();
            this.wine = new System.Windows.Forms.TextBox();
            this.vodka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.komieta = new System.Windows.Forms.RadioButton();
            this.mezczyzna = new System.Windows.Forms.RadioButton();
            this.policz = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // body
            // 
            this.body.AutoSize = true;
            this.body.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.body.Location = new System.Drawing.Point(439, 51);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(156, 69);
            this.body.TabIndex = 1;
            this.body.Text = "Body mass [kg]";
            // 
            // mass
            // 
            this.mass.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mass.Location = new System.Drawing.Point(601, 72);
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(54, 26);
            this.mass.TabIndex = 3;
            this.mass.Text = "60";
            this.mass.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLiczba_Validation);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mezczyzna);
            this.groupBox1.Controls.Add(this.komieta);
            this.groupBox1.Location = new System.Drawing.Point(502, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sex";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // beer
            // 
            this.beer.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.beer.Location = new System.Drawing.Point(601, 203);
            this.beer.Name = "beer";
            this.beer.Size = new System.Drawing.Size(54, 26);
            this.beer.TabIndex = 7;
            this.beer.Text = "0";
            this.beer.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLiczba_Validation);
            // 
            // wine
            // 
            this.wine.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wine.Location = new System.Drawing.Point(601, 256);
            this.wine.Name = "wine";
            this.wine.Size = new System.Drawing.Size(54, 26);
            this.wine.TabIndex = 8;
            this.wine.Text = "0";
            this.wine.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLiczba_Validation);
            // 
            // vodka
            // 
            this.vodka.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vodka.Location = new System.Drawing.Point(601, 312);
            this.vodka.Name = "vodka";
            this.vodka.Size = new System.Drawing.Size(54, 26);
            this.vodka.TabIndex = 9;
            this.vodka.Text = "0";
            this.vodka.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLiczba_Validation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(458, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 69);
            this.label1.TabIndex = 10;
            this.label1.Text = "Beer [250ml]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(456, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 69);
            this.label2.TabIndex = 11;
            this.label2.Text = "Wine [100ml]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DejaVu Math TeX Gyre", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(454, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 69);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vodka [50ml]";
            // 
            // komieta
            // 
            this.komieta.AutoSize = true;
            this.komieta.Checked = true;
            this.komieta.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.komieta.Location = new System.Drawing.Point(27, 18);
            this.komieta.Name = "komieta";
            this.komieta.Size = new System.Drawing.Size(36, 23);
            this.komieta.TabIndex = 0;
            this.komieta.TabStop = true;
            this.komieta.Text = "K";
            this.komieta.UseVisualStyleBackColor = true;
            // 
            // mezczyzna
            // 
            this.mezczyzna.AutoSize = true;
            this.mezczyzna.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mezczyzna.Location = new System.Drawing.Point(69, 18);
            this.mezczyzna.Name = "mezczyzna";
            this.mezczyzna.Size = new System.Drawing.Size(39, 23);
            this.mezczyzna.TabIndex = 1;
            this.mezczyzna.Text = "M";
            this.mezczyzna.UseVisualStyleBackColor = true;
            // 
            // policz
            // 
            this.policz.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.policz.Location = new System.Drawing.Point(470, 359);
            this.policz.Name = "policz";
            this.policz.Size = new System.Drawing.Size(199, 49);
            this.policz.TabIndex = 13;
            this.policz.Text = "Oblicz";
            this.policz.UseVisualStyleBackColor = true;
            this.policz.Click += new System.EventHandler(this.policz_Click);
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.policz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vodka);
            this.Controls.Add(this.wine);
            this.Controls.Add(this.beer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mass);
            this.Controls.Add(this.body);
            this.Name = "FormApp";
            this.Text = "Alkomat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label body;
        private System.Windows.Forms.TextBox mass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox beer;
        private System.Windows.Forms.TextBox wine;
        private System.Windows.Forms.TextBox vodka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton mezczyzna;
        private System.Windows.Forms.RadioButton komieta;
        private System.Windows.Forms.Button policz;
    }
}

