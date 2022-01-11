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
    public partial class Add_Religion : Form
    {
        public Add_Religion()
        {
            InitializeComponent();
        }

        private void btnAddReligion_Click(object sender, EventArgs e)
        {
            try
            {
                var m = new PathfinderEntities();
                var r = new Religion();

                r.Id = Convert.ToInt32(txtReligionId.Text.Trim());
                r.Name = txtReligionName.Text.Trim();

                m.AddToReligions(r);
                m.SaveChanges();
                MessageBox.Show(@"Religion has been saved successfully");

                cleartext();
            }
            catch(Exception)
            {
                MessageBox.Show(@"Input String was not correct format or already exists.Try to another id.Thank you.");
            }
        }

        private void cleartext()
        {
            txtReligionId.Text = txtReligionName.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.close();
            Motherfrom nextfrom = new Motherfrom();
            this.Hide();
            nextfrom.ShowDialog();
            this.Close();
        }
    }
}
