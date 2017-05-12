namespace WindowsFormsApplication1.View.Personenverwaltung
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
            this.sortiereNachnameBtn = new System.Windows.Forms.Button();
            this.sortierePLZBtn = new System.Windows.Forms.Button();
            this.sortiereOrtBtn = new System.Windows.Forms.Button();
            this.speichereBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(476, 108);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // sortiereNachnameBtn
            // 
            this.sortiereNachnameBtn.Location = new System.Drawing.Point(12, 125);
            this.sortiereNachnameBtn.Name = "sortiereNachnameBtn";
            this.sortiereNachnameBtn.Size = new System.Drawing.Size(112, 23);
            this.sortiereNachnameBtn.TabIndex = 2;
            this.sortiereNachnameBtn.Text = "Sortiere (Nachname)";
            this.sortiereNachnameBtn.UseVisualStyleBackColor = true;
            this.sortiereNachnameBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sortierePLZBtn
            // 
            this.sortierePLZBtn.Location = new System.Drawing.Point(130, 125);
            this.sortierePLZBtn.Name = "sortierePLZBtn";
            this.sortierePLZBtn.Size = new System.Drawing.Size(80, 23);
            this.sortierePLZBtn.TabIndex = 3;
            this.sortierePLZBtn.Text = "Sortiere (PLZ)";
            this.sortierePLZBtn.UseVisualStyleBackColor = true;
            this.sortierePLZBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // sortiereOrtBtn
            // 
            this.sortiereOrtBtn.Location = new System.Drawing.Point(216, 125);
            this.sortiereOrtBtn.Name = "sortiereOrtBtn";
            this.sortiereOrtBtn.Size = new System.Drawing.Size(74, 23);
            this.sortiereOrtBtn.TabIndex = 4;
            this.sortiereOrtBtn.Text = "Sortiere (Ort)";
            this.sortiereOrtBtn.UseVisualStyleBackColor = true;
            this.sortiereOrtBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // speichereBtn
            // 
            this.speichereBtn.Location = new System.Drawing.Point(396, 125);
            this.speichereBtn.Name = "speichereBtn";
            this.speichereBtn.Size = new System.Drawing.Size(94, 23);
            this.speichereBtn.TabIndex = 7;
            this.speichereBtn.Text = "Neue Person";
            this.speichereBtn.UseVisualStyleBackColor = true;
            this.speichereBtn.Click += new System.EventHandler(this.speichereBtn_Click);
            // 
            // Bericht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 171);
            this.Controls.Add(this.speichereBtn);
            this.Controls.Add(this.sortiereOrtBtn);
            this.Controls.Add(this.sortierePLZBtn);
            this.Controls.Add(this.sortiereNachnameBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "Bericht";
            this.Text = "Bericht";
            this.Load += new System.EventHandler(this.Bericht_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button sortierePLZBtn;
        private System.Windows.Forms.Button sortiereNachnameBtn;
        private System.Windows.Forms.Button sortiereOrtBtn;
        private System.Windows.Forms.Button speichereBtn;
    }
}