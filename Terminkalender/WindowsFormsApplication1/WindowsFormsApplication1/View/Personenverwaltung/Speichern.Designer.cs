namespace WindowsFormsApplication1.View
{
    partial class Speichern
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vornameInput = new System.Windows.Forms.TextBox();
            this.nachnameInput = new System.Windows.Forms.TextBox();
            this.plzInput = new System.Windows.Forms.TextBox();
            this.wohnortInput = new System.Windows.Forms.TextBox();
            this.adresseInput = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bitte geben Sie die erforderlichen Daten ein.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vorname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresse:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wohnort:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "PLZ:";
            // 
            // vornameInput
            // 
            this.vornameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vornameInput.Location = new System.Drawing.Point(97, 34);
            this.vornameInput.MaxLength = 50;
            this.vornameInput.Name = "vornameInput";
            this.vornameInput.Size = new System.Drawing.Size(100, 20);
            this.vornameInput.TabIndex = 6;
            // 
            // nachnameInput
            // 
            this.nachnameInput.Location = new System.Drawing.Point(97, 60);
            this.nachnameInput.Name = "nachnameInput";
            this.nachnameInput.Size = new System.Drawing.Size(100, 20);
            this.nachnameInput.TabIndex = 7;
            // 
            // plzInput
            // 
            this.plzInput.Location = new System.Drawing.Point(97, 138);
            this.plzInput.Name = "plzInput";
            this.plzInput.Size = new System.Drawing.Size(100, 20);
            this.plzInput.TabIndex = 10;
            // 
            // wohnortInput
            // 
            this.wohnortInput.Location = new System.Drawing.Point(97, 86);
            this.wohnortInput.Name = "wohnortInput";
            this.wohnortInput.Size = new System.Drawing.Size(100, 20);
            this.wohnortInput.TabIndex = 8;
            // 
            // adresseInput
            // 
            this.adresseInput.Location = new System.Drawing.Point(97, 112);
            this.adresseInput.Name = "adresseInput";
            this.adresseInput.Size = new System.Drawing.Size(100, 20);
            this.adresseInput.TabIndex = 9;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(12, 187);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Abbrechen";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(169, 187);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Speichern";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Speichern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 222);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.adresseInput);
            this.Controls.Add(this.wohnortInput);
            this.Controls.Add(this.plzInput);
            this.Controls.Add(this.nachnameInput);
            this.Controls.Add(this.vornameInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Speichern";
            this.Text = "Personenverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vornameInput;
        private System.Windows.Forms.TextBox nachnameInput;
        private System.Windows.Forms.TextBox plzInput;
        private System.Windows.Forms.TextBox wohnortInput;
        private System.Windows.Forms.TextBox adresseInput;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}