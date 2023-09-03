using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Infrastructure;


namespace PCM_
{
    public partial class Startseite : Form
    {
        public Startseite()
        {
            InitializeComponent();
        }

        private void Startseite_Load(object sender, EventArgs e)
        {
            lbl_Datum.Text = DateTime.Now.ToString("dddd,  MMM dd yyyy , HH:mm:ss");
            lbl_Datum.BorderStyle = BorderStyle.FixedSingle;

            DatabaseFacade facade = new DatabaseFacade(new DataContext());
            facade.EnsureCreated();

        }

        public void ChangeColor_Enter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Cyan;
        }
        public void ChangeColor_Leaver(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.GhostWhite;
        }


        private void btn_Neuer_Kunde_Click(object sender, EventArgs e)
        {
            NeuerKunde Kunde = new NeuerKunde();
            Kunde.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}