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
    public partial class Add_Shift : Form
    {
        public Add_Shift()
        {
            InitializeComponent();
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            try
            {
                var m = new PathfinderEntities();
                var s = new ShiftInfo();

                s.Id = Convert.ToInt32(txtShiftId.Text.Trim());
                s.Name = txtShiftName.Text.Trim();

                m.AddToShiftInfoes(s);
                m.SaveChanges();
                MessageBox.Show("Shift has been added successfully");

                cleartext();
                btnAddShift.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Input String was not correct format or already exists.Try to another id.Thank you.");
            }
            //foreach (var item in this.Controls)
            //{
            //    if (item.GetType().Equals(typeof(Button)))
            //    {
            //        Button btnAddShift = item as Button;
            //        btnAddShift.Text = "Exit";
            //    }                
            //}
                     
        }

        private void cleartext()
        {
            txtShiftId.Text = txtShiftName.Text = string.Empty;
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
