namespace PCM_
{
    partial class Startseite
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startseite));
            lbl_logo = new Label();
            lbl_Datum = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btn_Neuer_Kunde = new Button();
            btn_Kunden_suchen = new Button();
            monthCalendar1 = new MonthCalendar();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // lbl_logo
            // 
            lbl_logo.AutoSize = true;
            lbl_logo.BackColor = Color.GhostWhite;
            lbl_logo.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_logo.Location = new Point(0, 0);
            lbl_logo.Name = "lbl_logo";
            lbl_logo.Size = new Size(307, 22);
            lbl_logo.TabIndex = 0;
            lbl_logo.Text = "Persönlicher Kontaktmanager";
            // 
            // lbl_Datum
            // 
            lbl_Datum.FlatStyle = FlatStyle.Flat;
            lbl_Datum.Location = new Point(0, 22);
            lbl_Datum.Name = "lbl_Datum";
            lbl_Datum.Size = new Size(250, 25);
            lbl_Datum.TabIndex = 1;
            // 
            // btn_Neuer_Kunde
            // 
            btn_Neuer_Kunde.BackColor = Color.GhostWhite;
            btn_Neuer_Kunde.FlatAppearance.BorderSize = 0;
            btn_Neuer_Kunde.FlatStyle = FlatStyle.Flat;
            btn_Neuer_Kunde.ForeColor = SystemColors.ControlText;
            btn_Neuer_Kunde.Location = new Point(0, 50);
            btn_Neuer_Kunde.Margin = new Padding(5);
            btn_Neuer_Kunde.Name = "btn_Neuer_Kunde";
            btn_Neuer_Kunde.Size = new Size(120, 25);
            btn_Neuer_Kunde.TabIndex = 2;
            btn_Neuer_Kunde.Text = "Neuer Kunde";
            btn_Neuer_Kunde.UseVisualStyleBackColor = false;
            btn_Neuer_Kunde.Click += btn_Neuer_Kunde_Click;
            btn_Neuer_Kunde.MouseEnter += ChangeColor_Enter;
            btn_Neuer_Kunde.MouseLeave += ChangeColor_Leaver;
            // 
            // btn_Kunden_suchen
            // 
            btn_Kunden_suchen.BackColor = Color.GhostWhite;
            btn_Kunden_suchen.FlatAppearance.BorderSize = 0;
            btn_Kunden_suchen.FlatStyle = FlatStyle.Flat;
            btn_Kunden_suchen.ForeColor = SystemColors.ControlText;
            btn_Kunden_suchen.Location = new Point(0, 85);
            btn_Kunden_suchen.Margin = new Padding(5);
            btn_Kunden_suchen.Name = "btn_Kunden_suchen";
            btn_Kunden_suchen.Size = new Size(120, 25);
            btn_Kunden_suchen.TabIndex = 3;
            btn_Kunden_suchen.Text = "Kunden suchen";
            btn_Kunden_suchen.UseVisualStyleBackColor = false;
            btn_Kunden_suchen.MouseEnter += ChangeColor_Enter;
            btn_Kunden_suchen.MouseLeave += ChangeColor_Leaver;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.GhostWhite;
            monthCalendar1.CalendarDimensions = new Size(4, 3);
            monthCalendar1.Location = new Point(129, 50);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.SelectionRange = new SelectionRange(new DateTime(2023, 1, 1, 0, 0, 0, 0), new DateTime(2023, 1, 7, 0, 0, 0, 0));
            monthCalendar1.TabIndex = 4;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(753, 517);
            btn_cancel.Margin = new Padding(5);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Padding = new Padding(3);
            btn_cancel.Size = new Size(100, 30);
            btn_cancel.TabIndex = 36;
            btn_cancel.Text = "Abbrechen";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // Startseite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 210, 234);
            ClientSize = new Size(884, 561);
            Controls.Add(btn_cancel);
            Controls.Add(monthCalendar1);
            Controls.Add(btn_Kunden_suchen);
            Controls.Add(btn_Neuer_Kunde);
            Controls.Add(lbl_Datum);
            Controls.Add(lbl_logo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Startseite";
            Text = "Startseite";
            Load += Startseite_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_logo;
        private Label lbl_Datum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_Neuer_Kunde;
        private Button btn_Kunden_suchen;
        private MonthCalendar monthCalendar1;
        private Button btn_cancel;
    }
}