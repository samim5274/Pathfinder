using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Information
{
    public partial class Add_Gender : Form
    {
        public Add_Gender()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var m = new PathfinderEntities();
                var g = new GendarInfo();

                g.Id = Convert.ToInt32(txtId.Text.Trim());
                g.Name = txtName.Text.Trim();

                m.AddToGendarInfoes(g);
                m.SaveChanges();
                MessageBox.Show(@"Add Gender Successfully");
                cleartext();
            }
            catch(Exception)
            {
                MessageBox.Show(@"Input String was not correct format or already exists.Try to another id.Thank you.");
            }
        }

        private void cleartext()
        {
            txtId.Text = txtName.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Motherfrom nextfrom = new Motherfrom();
            this.Hide();
            nextfrom.ShowDialog();
            this.Close();
        }
    }
}
