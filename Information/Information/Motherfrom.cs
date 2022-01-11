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
    public partial class Motherfrom : Form
    {
        public Motherfrom()
        {
            InitializeComponent();
        }

        private void addInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new addinformation();
            obj.Show();
            Visible = false;

            //addinformation nextfrom = new addinformation();
            //this.Hide();
            //nextfrom.ShowDialog();
            //this.Close();

        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var obj = new AddDepartment();
            //obj.ShowDialog();

            AddDepartment nextfrom = new AddDepartment();
            this.Hide();
            nextfrom.ShowDialog();
            this.Close();
        }

        private void addGenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var obj = new Add_Gender();
            //obj.ShowDialog();

            Add_Gender nextfrom = new Add_Gender();
            this.Hide();
            nextfrom.ShowDialog();
            this.Close();
        }

        private void addReligionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var obj = new Add_Religion();
            //obj.ShowDialog();
            Add_Religion nextfrom = new Add_Religion();
            this.Hide();
            nextfrom.ShowDialog();
            this.Close();
        }

        private void addShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var obj = new Add_Shift();
            //obj.ShowDialog();
            Add_Shift nextfrom = new Add_Shift();
            this.Hide();
            nextfrom.ShowDialog();
            this.Close();
        }

        private void departmentWiseInformationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //var obj = new Department_Wise_Information();
            //obj.ShowDialog();

            Department_Wise_Information nextfrom = new Department_Wise_Information();
            this.Hide();
            nextfrom.ShowDialog();
            this.Close();
        }

        private void creatNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new NewUser();
            obj.ShowDialog();
        }

        private void Motherfrom_Load(object sender, EventArgs e)
        {
            //int w = Screen.PrimaryScreen.Bounds.Width;
            //int h = Screen.PrimaryScreen.Bounds.Height;
            //this.Location = new Point(0,0);
            //this.Size = new Size(w,h);
        }

        private void departmentCrystralReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new DepartmentWiseReportFrom();
            obj.ShowDialog();
        }

        private void backUpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var obj = new BackupFrom();
            obj.ShowDialog();
        }

    }
}
