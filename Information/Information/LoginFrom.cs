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
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Motherfrom nextfrom = new Motherfrom();
            this.Hide();
            nextfrom.ShowDialog();
            this.Close();


            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(@"Pls Enter user name and password...", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var context = new PathfinderEntities())
                {
                    var q = from log in context.S_Login
                            where log.UserName == txtUsername.Text && log.Password == txtPassword.Text
                            select log;
                    if (q.SingleOrDefault() != null)
                    {
                        //MessageBox.Show(@"Login Successfully", @"Message", MessageBoxButtons.OK,
                        //                MessageBoxIcon.Information);
                        txtUsername.Text = txtPassword.Text = string.Empty;
                        var obj = new Motherfrom();
                        obj.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show(@"Invalid user Name and Password pls try again", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //  throw new Exception(ex.Message);
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginFrom_Load(object sender, EventArgs e)
        {

        }
    }
}
