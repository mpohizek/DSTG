namespace Zadatak3
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
            this.txtRjesenjeOutput = new System.Windows.Forms.TextBox();
            this.btnPokreniAlgoritam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRjesenjeOutput
            // 
            this.txtRjesenjeOutput.Location = new System.Drawing.Point(40, 13);
            this.txtRjesenjeOutput.Multiline = true;
            this.txtRjesenjeOutput.Name = "txtRjesenjeOutput";
            this.txtRjesenjeOutput.Size = new System.Drawing.Size(648, 283);
            this.txtRjesenjeOutput.TabIndex = 0;
            // 
            // btnPokreniAlgoritam
            // 
            this.btnPokreniAlgoritam.Location = new System.Drawing.Point(298, 328);
            this.btnPokreniAlgoritam.Name = "btnPokreniAlgoritam";
            this.btnPokreniAlgoritam.Size = new System.Drawing.Size(90, 59);
            this.btnPokreniAlgoritam.TabIndex = 1;
            this.btnPokreniAlgoritam.Text = "Pokreni algoritam";
            this.btnPokreniAlgoritam.UseVisualStyleBackColor = true;
            this.btnPokreniAlgoritam.Click += new System.EventHandler(this.btnPokreniAlgoritam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 423);
            this.Controls.Add(this.btnPokreniAlgoritam);
            this.Controls.Add(this.txtRjesenjeOutput);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Missionaries & Cannibals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRjesenjeOutput;
        private System.Windows.Forms.Button btnPokreniAlgoritam;
    }
}

