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
    public partial class DepartmentWiseReportFrom : Form
    {
        public DepartmentWiseReportFrom()
        {
            InitializeComponent();
        }

        private void DepartmentWiseReportFrom_Load(object sender, EventArgs e)
        {
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
            // var list = mngr.GettAllDepartment();
            cbxDepartment.DisplayMember = "DepartmentName";
            cbxDepartment.ValueMember = "Id";
            cbxDepartment.DataSource = list;
        }

        private void cbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                int sId = Convert.ToInt32(txtStudentId.Text.Trim());
                int dId = Convert.ToInt32(cbxDepartment.SelectedValue);

                var rpt = new rpt_InformationReport();
                var report = new ReportViewer();

                rpt.SetParameterValue("@IID", sId);
                rpt.SetParameterValue("@DID", dId);

                //report.crystalReportViewer1.Show();

                rpt.DataSourceConnections.Clear();
                report.crystalReportViewer1.ReportSource = rpt;
                report.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Input are not found !!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
