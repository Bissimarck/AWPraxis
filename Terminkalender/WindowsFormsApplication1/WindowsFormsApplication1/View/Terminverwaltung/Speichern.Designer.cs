namespace WindowsFormsApplication1.View.Terminverwaltung
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.personSelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.abbrechenBtn = new System.Windows.Forms.Button();
            this.speichernBtn = new System.Windows.Forms.Button();
            this.locationInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.descriptionInput = new System.Windows.Forms.TextBox();
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
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(114, 38);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Treffpunkt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Beschreibung:";
            // 
            // personSelect
            // 
            this.personSelect.FormattingEnabled = true;
            this.personSelect.Location = new System.Drawing.Point(114, 129);
            this.personSelect.Name = "personSelect";
            this.personSelect.Size = new System.Drawing.Size(200, 21);
            this.personSelect.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Person:";
            // 
            // abbrechenBtn
            // 
            this.abbrechenBtn.Location = new System.Drawing.Point(12, 187);
            this.abbrechenBtn.Name = "abbrechenBtn";
            this.abbrechenBtn.Size = new System.Drawing.Size(75, 23);
            this.abbrechenBtn.TabIndex = 7;
            this.abbrechenBtn.Text = "Abbrechen";
            this.abbrechenBtn.UseVisualStyleBackColor = true;
            this.abbrechenBtn.Click += new System.EventHandler(this.abbrechenBtn_Click);
            // 
            // speichernBtn
            // 
            this.speichernBtn.Location = new System.Drawing.Point(239, 186);
            this.speichernBtn.Name = "speichernBtn";
            this.speichernBtn.Size = new System.Drawing.Size(75, 24);
            this.speichernBtn.TabIndex = 8;
            this.speichernBtn.Text = "Speichern";
            this.speichernBtn.UseVisualStyleBackColor = true;
            this.speichernBtn.Click += new System.EventHandler(this.speichernBtn_Click);
            // 
            // locationInput
            // 
            this.locationInput.Location = new System.Drawing.Point(114, 69);
            this.locationInput.Name = "locationInput";
            this.locationInput.Size = new System.Drawing.Size(200, 20);
            this.locationInput.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(114, 100);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(200, 20);
            this.descriptionInput.TabIndex = 11;
            // 
            // Speichern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 222);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.locationInput);
            this.Controls.Add(this.speichernBtn);
            this.Controls.Add(this.abbrechenBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.personSelect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Speichern";
            this.Text = "Speichern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox personSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button abbrechenBtn;
        private System.Windows.Forms.Button speichernBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.TextBox locationInput;
    }
}