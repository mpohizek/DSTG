namespace Parking
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPronadiMjesto = new System.Windows.Forms.Button();
            this.tbImeSekcije = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajPMjesto = new System.Windows.Forms.Button();
            this.lblUdaljenostDoMjesta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBrojParkMjesta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(466, 372);
            this.textBox1.TabIndex = 0;
            // 
            // btnPronadiMjesto
            // 
            this.btnPronadiMjesto.Location = new System.Drawing.Point(12, 409);
            this.btnPronadiMjesto.Name = "btnPronadiMjesto";
            this.btnPronadiMjesto.Size = new System.Drawing.Size(776, 29);
            this.btnPronadiMjesto.TabIndex = 1;
            this.btnPronadiMjesto.Text = "Pronađi najbliže parkirno mjesto";
            this.btnPronadiMjesto.UseVisualStyleBackColor = true;
            this.btnPronadiMjesto.Click += new System.EventHandler(this.btnPronadiMjesto_Click);
            // 
            // tbImeSekcije
            // 
            this.tbImeSekcije.Location = new System.Drawing.Point(636, 32);
            this.tbImeSekcije.Name = "tbImeSekcije";
            this.tbImeSekcije.Size = new System.Drawing.Size(100, 20);
            this.tbImeSekcije.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime sekcije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Udaljenost do parkirnog mjesta:";
            // 
            // btnDodajPMjesto
            // 
            this.btnDodajPMjesto.Location = new System.Drawing.Point(578, 99);
            this.btnDodajPMjesto.Name = "btnDodajPMjesto";
            this.btnDodajPMjesto.Size = new System.Drawing.Size(128, 49);
            this.btnDodajPMjesto.TabIndex = 6;
            this.btnDodajPMjesto.Text = "Dodaj slobodno parkirno mjesto";
            this.btnDodajPMjesto.UseVisualStyleBackColor = true;
            this.btnDodajPMjesto.Click += new System.EventHandler(this.btnDodajPMjesto_Click);
            // 
            // lblUdaljenostDoMjesta
            // 
            this.lblUdaljenostDoMjesta.AutoSize = true;
            this.lblUdaljenostDoMjesta.Location = new System.Drawing.Point(684, 378);
            this.lblUdaljenostDoMjesta.Name = "lblUdaljenostDoMjesta";
            this.lblUdaljenostDoMjesta.Size = new System.Drawing.Size(18, 15);
            this.lblUdaljenostDoMjesta.TabIndex = 7;
            this.lblUdaljenostDoMjesta.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Broj parkirnog mjesta";
            // 
            // tbBrojParkMjesta
            // 
            this.tbBrojParkMjesta.Location = new System.Drawing.Point(636, 58);
            this.tbBrojParkMjesta.Name = "tbBrojParkMjesta";
            this.tbBrojParkMjesta.Size = new System.Drawing.Size(100, 20);
            this.tbBrojParkMjesta.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBrojParkMjesta);
            this.Controls.Add(this.lblUdaljenostDoMjesta);
            this.Controls.Add(this.btnDodajPMjesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbImeSekcije);
            this.Controls.Add(this.btnPronadiMjesto);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPronadiMjesto;
        private System.Windows.Forms.TextBox tbImeSekcije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajPMjesto;
        private System.Windows.Forms.Label lblUdaljenostDoMjesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBrojParkMjesta;
    }
}

