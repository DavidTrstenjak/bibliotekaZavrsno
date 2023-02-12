namespace bibliotekaZavrsno
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegistrirajKorisnika = new System.Windows.Forms.Button();
            this.buttonPosudiKnjigu = new System.Windows.Forms.Button();
            this.buttonUnesiKnjigu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Helper";
            // 
            // buttonRegistrirajKorisnika
            // 
            this.buttonRegistrirajKorisnika.BackColor = System.Drawing.Color.Bisque;
            this.buttonRegistrirajKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrirajKorisnika.Location = new System.Drawing.Point(293, 113);
            this.buttonRegistrirajKorisnika.Name = "buttonRegistrirajKorisnika";
            this.buttonRegistrirajKorisnika.Size = new System.Drawing.Size(182, 67);
            this.buttonRegistrirajKorisnika.TabIndex = 1;
            this.buttonRegistrirajKorisnika.Text = "Registriraj korisnika";
            this.buttonRegistrirajKorisnika.UseVisualStyleBackColor = false;
            this.buttonRegistrirajKorisnika.Click += new System.EventHandler(this.buttonRegistrirajKorisnika_Click);
            // 
            // buttonPosudiKnjigu
            // 
            this.buttonPosudiKnjigu.BackColor = System.Drawing.Color.Bisque;
            this.buttonPosudiKnjigu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPosudiKnjigu.Location = new System.Drawing.Point(293, 205);
            this.buttonPosudiKnjigu.Name = "buttonPosudiKnjigu";
            this.buttonPosudiKnjigu.Size = new System.Drawing.Size(182, 67);
            this.buttonPosudiKnjigu.TabIndex = 2;
            this.buttonPosudiKnjigu.Text = "Posudi knjigu";
            this.buttonPosudiKnjigu.UseVisualStyleBackColor = false;
            this.buttonPosudiKnjigu.Click += new System.EventHandler(this.buttonPosudiKnjigu_Click);
            // 
            // buttonUnesiKnjigu
            // 
            this.buttonUnesiKnjigu.BackColor = System.Drawing.Color.Bisque;
            this.buttonUnesiKnjigu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnesiKnjigu.Location = new System.Drawing.Point(293, 295);
            this.buttonUnesiKnjigu.Name = "buttonUnesiKnjigu";
            this.buttonUnesiKnjigu.Size = new System.Drawing.Size(182, 67);
            this.buttonUnesiKnjigu.TabIndex = 3;
            this.buttonUnesiKnjigu.Text = "Unesi knjigu";
            this.buttonUnesiKnjigu.UseVisualStyleBackColor = false;
            this.buttonUnesiKnjigu.Click += new System.EventHandler(this.buttonUnesiKnjigu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUnesiKnjigu);
            this.Controls.Add(this.buttonPosudiKnjigu);
            this.Controls.Add(this.buttonRegistrirajKorisnika);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Name = "Form1";
            this.Text = "BookHelper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegistrirajKorisnika;
        private System.Windows.Forms.Button buttonPosudiKnjigu;
        private System.Windows.Forms.Button buttonUnesiKnjigu;
    }
}

