using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Information
{
    public partial class Department_Wise_Information : Form
    {
        public Department_Wise_Information()
        {
            InitializeComponent();
        }

        private void Department_Wise_Information_Load(object sender, EventArgs e)
        {
            FillGrid();
            FillDepartment();
        }

        private void FillDepartment()
        {
            var mngr = new InformationManager();


            var d = new DepartmentInfo();
            d.Id = 0;
            d.DepartmentName = "All Department";

            var list = mngr.GettAllDepartment();

            var dlist = new List<DepartmentInfo>();
            dlist.Add(d);
            list.AddRange(dlist);

            cbxDepartment.DisplayMember = "DepartmentName";
            cbxDepartment.ValueMember = "Id";
            cbxDepartment.DataSource = list;
        }

        private void FillGrid()
        {
            var mngr = new InformationManager();
            var list = mngr.GettAllInformation();
            DepartmentGrid.DataSource = list;
        }

        private void btnScarch_Click(object sender, EventArgs e)
        {
            try
            {
                var sid = Convert.ToInt32(txtStudentId.Text.Trim());
                var did = Convert.ToInt32(cbxDepartment.SelectedValue);

                var smngr = new InformationManager();

                var list = smngr.GettAllDepartmentWiseInformation(sid, did);
                DepartmentGrid.DataSource = list;
            }
            catch (Exception)
            {
                MessageBox.Show(@"Input String was not correct format or already exists.Try to another id.Thank you.");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var Print = new DGVPrinter();

            Print.Title = "Department Wise Information";
            Print.SubTitle = "Samim Software Technology(SST)";
            Print.PageNumbers = true;
            Print.PageNumberInHeader = false;
            Print.PorportionalColumns = false;
            Print.HeaderCellAlignment = StringAlignment.Near;
            Print.Footer = "SST";
            Print.FooterSpacing = 15;
            Print.PrintPreviewDataGridView(DepartmentGrid);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            //var obj = new Motherfrom();
            //obj.ShowDialog();

            Motherfrom nextfrom = new Motherfrom();
            this.Hide();
            nextfrom.ShowDialog();
            this.Close();
        }
    }
}
