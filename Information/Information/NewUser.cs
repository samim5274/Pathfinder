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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(@"Pls Enter user name and password...", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var contxt = new PathfinderEntities();

                var us = new S_Login();

                us.UserName = txtUsername.Text.Trim();
                us.Password = txtPassword.Text.Trim();

                contxt.AddToS_Login(us);
                contxt.SaveChanges();
                MessageBox.Show(@"New User addedd successfully.");
                ClearTxtbox();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Input String was not correct format or already exists.Try to another id.Thank you.");
            }
        }

        private void ClearTxtbox()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            var obj = new InformationManager();
            var list = obj.GettAllNewuser();
            datagridNewUser.DataSource = list;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
