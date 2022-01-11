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
    public partial class addinformation : Form
    {
        public addinformation()
        {
            InitializeComponent();
        }

        private void addinformation_Load(object sender, EventArgs e)
        {
            dtpDathOfBirth.Value = DateTime.Now;

            FillDepartment();
            FillGender();
            FillSemester();
            FillReligion();
            FillShift();
            FillGrid();

            //int w = Screen.PrimaryScreen.Bounds.Width;
            //int h = Screen.PrimaryScreen.Bounds.Height;
            //this.Location = new Point(0, 0);
            //this.Size = new Size(w, h);

        }

        private void FillGrid()
        {
            var obj = new InformationManager();
            var list = obj.GettAllInformation();
            datagridinformation.DataSource = list;
        }
        private void FillShift()
        {
            var InformationManager = new InformationManager();
            var list = new InformationManager().GettAllShift();
            cbxShift.DisplayMember = "Name";
            cbxShift.ValueMember = "Id";
            cbxShift.DataSource = list;
        }
        private void FillReligion()
        {
            var InformationManager = new InformationManager();
            var list = new InformationManager().GettAllReligion();
            cbxReligion.DisplayMember = "Name";
            cbxReligion.ValueMember = "Id";
            cbxReligion.DataSource = list;
        }
        private void FillSemester()
        {
            var InformationManager = new InformationManager();
            var list = new InformationManager().GettAllSemester();
            cbxSemester.DisplayMember = "Name";
            cbxSemester.ValueMember = "Id";
            cbxSemester.DataSource = list;
        }
        private void FillGender()
        {
            var InformationManager = new InformationManager();
            var list = new InformationManager().GettAllGender();
            cbxGender.DisplayMember = "Name";
            cbxGender.ValueMember = "Id";
            cbxGender.DataSource = list;
        }
        private void FillDepartment()
        {
           // var InformationManager = new InformationManager();
            var list = new InformationManager().GettAllDepartment();
            cbxDepartment.DisplayMember = "DepartmentName";
            cbxDepartment.ValueMember = "Id";
            cbxDepartment.DataSource = list;
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var pathfinderobj = new PathfinderEntities();
                var objinformation = new Information();

                objinformation.Id = Convert.ToInt32(txtId.Text.Trim());
                objinformation.Name = txtName.Text.Trim();
                objinformation.FatherName = txtFather.Text.Trim();
                objinformation.Address = txtAddress.Text.Trim();
                objinformation.Gurden_phone = Convert.ToInt32(txtGurdenPhone.Text.Trim());
                objinformation.Nationality = txtNationality.Text.Trim();
                objinformation.Phone = Convert.ToInt32(txtPhone.Text.Trim());

                objinformation.DateofBirth = Convert.ToDateTime(dtpDathOfBirth.Value);

                objinformation.SemesterID = Convert.ToInt32(cbxSemester.SelectedValue);
                objinformation.DepartmentId = Convert.ToInt32(cbxDepartment.SelectedValue);
                objinformation.GenderId = Convert.ToInt32(cbxGender.SelectedValue);
                objinformation.ReligionID = Convert.ToInt32(cbxReligion.SelectedValue);
                objinformation.ShiftId = Convert.ToInt32(cbxShift.SelectedValue);

                pathfinderobj.AddToInformation(objinformation);
                pathfinderobj.SaveChanges();
                MessageBox.Show(@"Saved Data Successfuly");
                ClearTxtbox();
                FillGrid();
                //button1.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Input String was not correct format or already exists.Try to another id.Thank you.");
            }
        }
        private void ClearTxtbox()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtFather.Text = string.Empty;
            txtNationality.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtGurdenPhone.Text = string.Empty;

            cbxShift.SelectedValue = string.Empty;
            cbxSemester.SelectedValue = string.Empty;
            cbxReligion.SelectedValue = string.Empty;
            cbxGender.SelectedValue = string.Empty;
            cbxDepartment.SelectedValue = string.Empty;

            //dtpDathOfBirth.Value = Convert.ToDateTime(info.DateofBirth);
        }
        private void btnScarch_Click(object sender, EventArgs e)
        {
            try
            {
                var pathfinderobj = new PathfinderEntities();

                var info =
                    pathfinderobj.Information.ToList().Where(x => x.Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();

                txtId.Text = info.Id.ToString();
                txtName.Text = info.Name;
                txtAddress.Text = info.Address;
                txtFather.Text = info.FatherName;
                txtNationality.Text = info.Nationality;
                txtPhone.Text = info.Phone.ToString();
                txtGurdenPhone.Text = info.Gurden_phone.ToString();

                cbxShift.SelectedValue = info.ShiftId;
                cbxSemester.SelectedValue = info.SemesterID;
                cbxReligion.SelectedValue = info.ReligionID;
                cbxGender.SelectedValue = info.GenderId;
                cbxDepartment.SelectedValue = info.DepartmentId;

                dtpDathOfBirth.Value = Convert.ToDateTime(info.DateofBirth);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Input String was not correct format or already exists.Try to another id.Thank you.");
            }
        }
        private void Update_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var pathfinderobj = new PathfinderEntities();

            //    var info =
            //        pathfinderobj.Information.ToList().Where(x => x.Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();

            //    info.Id = Convert.ToInt32(txtId.Text.Trim());
            //    info.Name = txtName.Text.Trim();
            //    info.FatherName = txtFather.Text.Trim();
            //    info.Address = txtAddress.Text.Trim();
            //    info.Gurden_phone = Convert.ToInt32(txtGurdenPhone.Text.Trim());
            //    info.Nationality = txtNationality.Text.Trim();
            //    info.Phone = Convert.ToInt32(txtPhone.Text.Trim());

            //    info.DateofBirth = Convert.ToDateTime(dtpDathOfBirth.Value);

            //    info.SemesterID = Convert.ToInt32(cbxSemester.SelectedValue);
            //    info.DepartmentId = Convert.ToInt32(cbxDepartment.SelectedValue);
            //    info.GenderId = Convert.ToInt32(cbxGender.SelectedValue);
            //    info.ReligionID = Convert.ToInt32(cbxReligion.SelectedValue);
            //    info.ShiftId = Convert.ToInt32(cbxShift.SelectedValue);


            //    //pathfinderobj.AddToInformation(info);
            //    pathfinderobj.SaveChanges();
            //    MessageBox.Show(@"Update Successfully");
            //    ClearTxtbox();
            //    FillGrid();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show(@"Input String was not correct format or already exists.Try to another id.Thank you.");
            //}

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var pathfinderobj = new PathfinderEntities();

                var info =
                    pathfinderobj.Information.ToList().Where(x => x.Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();

                pathfinderobj.DeleteObject(info);
                pathfinderobj.SaveChanges();
                MessageBox.Show(@"Delete");
                ClearTxtbox();
                FillGrid();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Input String was not correct format or already exists.Try to another id.Thank you.");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Motherfrom obj = new Motherfrom();
            obj.Show();
            //Motherfrom nextfrom = new Motherfrom();
            //this.Hide();
            //nextfrom.ShowDialog();
            //this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                var pathfinderobj = new PathfinderEntities();

                var info =
                    pathfinderobj.Information.ToList().Where(x => x.Id == int.Parse(txtScarch.Text.Trim())).FirstOrDefault();

                info.Id = Convert.ToInt32(txtId.Text.Trim());
                info.Name = txtName.Text.Trim();
                info.FatherName = txtFather.Text.Trim();
                info.Address = txtAddress.Text.Trim();
                info.Gurden_phone = Convert.ToInt32(txtGurdenPhone.Text.Trim());
                info.Nationality = txtNationality.Text.Trim();
                info.Phone = Convert.ToInt32(txtPhone.Text.Trim());

                info.DateofBirth = Convert.ToDateTime(dtpDathOfBirth.Value);

                info.SemesterID = Convert.ToInt32(cbxSemester.SelectedValue);
                info.DepartmentId = Convert.ToInt32(cbxDepartment.SelectedValue);
                info.GenderId = Convert.ToInt32(cbxGender.SelectedValue);
                info.ReligionID = Convert.ToInt32(cbxReligion.SelectedValue);
                info.ShiftId = Convert.ToInt32(cbxShift.SelectedValue);


                //pathfinderobj.AddToInformation(info);
                pathfinderobj.SaveChanges();
                MessageBox.Show(@"Update Successfully");
                ClearTxtbox();
                FillGrid();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Input String was not correct format or already exists.Try to another id.Thank you.");
            }
        }

        private void btnAddGender_Click(object sender, EventArgs e)
        {
            var obj = new Add_Gender();
            obj.ShowDialog();
        }

        
    }
}
