namespace WindowsFormsApplication1
{
    partial class Startseite
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.personenverwaltung_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(24, 45);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // personenverwaltung_button
            // 
            this.personenverwaltung_button.Location = new System.Drawing.Point(380, 10);
            this.personenverwaltung_button.Name = "personenverwaltung_button";
            this.personenverwaltung_button.Size = new System.Drawing.Size(186, 23);
            this.personenverwaltung_button.TabIndex = 1;
            this.personenverwaltung_button.Text = "Personenverwaltung aufrufen";
            this.personenverwaltung_button.UseVisualStyleBackColor = true;
            this.personenverwaltung_button.Click += new System.EventHandler(this.personenverwaltung_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Terminverwaltung aufrufen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Startseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personenverwaltung_button);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Startseite";
            this.Text = "Startseite";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button personenverwaltung_button;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
    }
}

