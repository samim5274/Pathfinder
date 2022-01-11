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
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
        }

        

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                var m = new PathfinderEntities();
                var d = new DepartmentInfo();

                d.Id = Convert.ToInt32(txtId.Text.Trim());
                d.DepartmentName = txtDepartmentName.Text.Trim();

                m.AddToDepartmentInfoes(d);
                m.SaveChanges();
                MessageBox.Show(@"Add Department Successfuly");
                cleartext();
            }
            catch( Exception)
            {
                MessageBox.Show(@"Input String was not correct format or already exists.Try to another id.Thank you.");
            }
        }

        private void cleartext()
        {
            txtId.Text = txtDepartmentName.Text = string.Empty;
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {
            FullGrid();
        }

        private void FullGrid()
        {
            var obj = new InformationManager();
            var list = obj.GettAllDepartmentName();
            datagridDepartmentfName.DataSource = list;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Motherfrom nextfrom = new Motherfrom();
            this.Hide();
            nextfrom.ShowDialog();
            this.Close();
        }
    }
}
