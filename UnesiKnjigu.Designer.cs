namespace bibliotekaZavrsno
{
    partial class UnesiKnjigu
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
            this.textBoxNazivKnjige = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUnesiAutora = new System.Windows.Forms.TextBox();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesi naziv knjige :";
            // 
            // textBoxNazivKnjige
            // 
            this.textBoxNazivKnjige.Location = new System.Drawing.Point(75, 64);
            this.textBoxNazivKnjige.Name = "textBoxNazivKnjige";
            this.textBoxNazivKnjige.Size = new System.Drawing.Size(177, 20);
            this.textBoxNazivKnjige.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unesi autora knjige :";
            // 
            // textBoxUnesiAutora
            // 
            this.textBoxUnesiAutora.Location = new System.Drawing.Point(75, 154);
            this.textBoxUnesiAutora.Name = "textBoxUnesiAutora";
            this.textBoxUnesiAutora.Size = new System.Drawing.Size(177, 20);
            this.textBoxUnesiAutora.TabIndex = 3;
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.BackColor = System.Drawing.Color.Bisque;
            this.buttonUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnesi.ForeColor = System.Drawing.Color.IndianRed;
            this.buttonUnesi.Location = new System.Drawing.Point(97, 236);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(138, 64);
            this.buttonUnesi.TabIndex = 4;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = false;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // UnesiKnjigu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(338, 370);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.textBoxUnesiAutora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNazivKnjige);
            this.Controls.Add(this.label1);
            this.Name = "UnesiKnjigu";
            this.Text = "BookHelper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNazivKnjige;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUnesiAutora;
        private System.Windows.Forms.Button buttonUnesi;
    }
}