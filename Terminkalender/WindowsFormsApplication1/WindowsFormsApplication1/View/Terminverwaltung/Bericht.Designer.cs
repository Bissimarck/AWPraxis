namespace WindowsFormsApplication1.View.Terminverwaltung
{
    partial class Bericht
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sortiereDatumBtn = new System.Windows.Forms.Button();
            this.sortiereTreffpunktBtn = new System.Windows.Forms.Button();
            this.sortiereNachnameBtn = new System.Windows.Forms.Button();
            this.speichereBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(476, 108);
            this.listBox1.TabIndex = 2;
            // 
            // sortiereDatumBtn
            // 
            this.sortiereDatumBtn.Location = new System.Drawing.Point(245, 126);
            this.sortiereDatumBtn.Name = "sortiereDatumBtn";
            this.sortiereDatumBtn.Size = new System.Drawing.Size(92, 23);
            this.sortiereDatumBtn.TabIndex = 7;
            this.sortiereDatumBtn.Text = "Sortiere (Datum)";
            this.sortiereDatumBtn.UseVisualStyleBackColor = true;
            this.sortiereDatumBtn.Click += new System.EventHandler(this.sortiereDatumBtn_Click);
            // 
            // sortiereTreffpunktBtn
            // 
            this.sortiereTreffpunktBtn.Location = new System.Drawing.Point(130, 126);
            this.sortiereTreffpunktBtn.Name = "sortiereTreffpunktBtn";
            this.sortiereTreffpunktBtn.Size = new System.Drawing.Size(109, 23);
            this.sortiereTreffpunktBtn.TabIndex = 6;
            this.sortiereTreffpunktBtn.Text = "Sortiere (Treffpunkt)";
            this.sortiereTreffpunktBtn.UseVisualStyleBackColor = true;
            this.sortiereTreffpunktBtn.Click += new System.EventHandler(this.sortiereTreffpunktBtn_Click);
            // 
            // sortiereNachnameBtn
            // 
            this.sortiereNachnameBtn.Location = new System.Drawing.Point(12, 126);
            this.sortiereNachnameBtn.Name = "sortiereNachnameBtn";
            this.sortiereNachnameBtn.Size = new System.Drawing.Size(112, 23);
            this.sortiereNachnameBtn.TabIndex = 5;
            this.sortiereNachnameBtn.Text = "Sortiere (Nachname)";
            this.sortiereNachnameBtn.UseVisualStyleBackColor = true;
            this.sortiereNachnameBtn.Click += new System.EventHandler(this.sortiereNachnameBtn_Click);
            // 
            // speichereBtn
            // 
            this.speichereBtn.Location = new System.Drawing.Point(394, 126);
            this.speichereBtn.Name = "speichereBtn";
            this.speichereBtn.Size = new System.Drawing.Size(94, 23);
            this.speichereBtn.TabIndex = 8;
            this.speichereBtn.Text = "Neuer Termin";
            this.speichereBtn.UseVisualStyleBackColor = true;
            this.speichereBtn.Click += new System.EventHandler(this.speichereBtn_Click_1);
            // 
            // Bericht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 171);
            this.Controls.Add(this.speichereBtn);
            this.Controls.Add(this.sortiereDatumBtn);
            this.Controls.Add(this.sortiereTreffpunktBtn);
            this.Controls.Add(this.sortiereNachnameBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "Bericht";
            this.Text = "Bericht";
            this.Load += new System.EventHandler(this.Bericht_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button sortiereDatumBtn;
        private System.Windows.Forms.Button sortiereTreffpunktBtn;
        private System.Windows.Forms.Button sortiereNachnameBtn;
        private System.Windows.Forms.Button speichereBtn;
    }
}