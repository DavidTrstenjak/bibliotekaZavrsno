namespace bibliotekaZavrsno
{
    partial class RegistrirajKorisnika
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
            this.textBoxImeKorisnika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrezimeKorisnika = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOibKorisnika = new System.Windows.Forms.TextBox();
            this.buttonUnesiKorisnika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(140, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime korisnika :";
            // 
            // textBoxImeKorisnika
            // 
            this.textBoxImeKorisnika.Location = new System.Drawing.Point(101, 91);
            this.textBoxImeKorisnika.Name = "textBoxImeKorisnika";
            this.textBoxImeKorisnika.Size = new System.Drawing.Size(163, 20);
            this.textBoxImeKorisnika.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime korisnika :";
            // 
            // textBoxPrezimeKorisnika
            // 
            this.textBoxPrezimeKorisnika.Location = new System.Drawing.Point(101, 170);
            this.textBoxPrezimeKorisnika.Name = "textBoxPrezimeKorisnika";
            this.textBoxPrezimeKorisnika.Size = new System.Drawing.Size(163, 20);
            this.textBoxPrezimeKorisnika.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "OIB korisnika :";
            // 
            // textBoxOibKorisnika
            // 
            this.textBoxOibKorisnika.Location = new System.Drawing.Point(101, 258);
            this.textBoxOibKorisnika.Name = "textBoxOibKorisnika";
            this.textBoxOibKorisnika.Size = new System.Drawing.Size(163, 20);
            this.textBoxOibKorisnika.TabIndex = 5;
            // 
            // buttonUnesiKorisnika
            // 
            this.buttonUnesiKorisnika.BackColor = System.Drawing.Color.Bisque;
            this.buttonUnesiKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnesiKorisnika.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonUnesiKorisnika.Location = new System.Drawing.Point(101, 335);
            this.buttonUnesiKorisnika.Name = "buttonUnesiKorisnika";
            this.buttonUnesiKorisnika.Size = new System.Drawing.Size(163, 58);
            this.buttonUnesiKorisnika.TabIndex = 6;
            this.buttonUnesiKorisnika.Text = "Unesi";
            this.buttonUnesiKorisnika.UseVisualStyleBackColor = false;
            this.buttonUnesiKorisnika.Click += new System.EventHandler(this.buttonUnesiKorisnika_Click);
            // 
            // RegistrirajKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(370, 425);
            this.Controls.Add(this.buttonUnesiKorisnika);
            this.Controls.Add(this.textBoxOibKorisnika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrezimeKorisnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxImeKorisnika);
            this.Controls.Add(this.label1);
            this.Name = "RegistrirajKorisnika";
            this.Text = "BookHelper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImeKorisnika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrezimeKorisnika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOibKorisnika;
        private System.Windows.Forms.Button buttonUnesiKorisnika;
    }
}