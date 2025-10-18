using LMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Reports_Form : Form
    {
        public Reports_Form()
        {
            InitializeComponent();
            LoadReports();
        }
        private void LoadReports()
        {
            using (var ctx = new LmsContext())
            {
                var data = ctx.Reports
                    .Select(r => new
                    {
                        r.RegNo,
                        r.BookNo,
                        r.UserId,
                        r.IssueReturn,
                        r.StaffId
                    })
                    .ToList();

                dgvReports.DataSource = data;
            }
        }

        private void ClearReportForm()
        {
            Book_Notxt.Text = string.Empty;
            User_IDtxt.Text = string.Empty;
            IssueReturntxt.Text = string.Empty;
            Staff_IDtxt.Text = string.Empty;
        }


        private void Report_addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Book_Notxt.Text) ||
       string.IsNullOrWhiteSpace(User_IDtxt.Text) ||
       string.IsNullOrWhiteSpace(IssueReturntxt.Text) ||
       string.IsNullOrWhiteSpace(Staff_IDtxt.Text))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            if (!int.TryParse(Book_Notxt.Text.Trim(), out int bookNo) ||
                !int.TryParse(User_IDtxt.Text.Trim(), out int userId) ||
                !int.TryParse(Staff_IDtxt.Text.Trim(), out int staffId))
            {
                MessageBox.Show("Book No, User ID, and Staff ID must be numbers.");
                return;
            }

            using (var ctx = new LmsContext())
            {
                var report = new Report
                {
                    BookNo = bookNo,
                    UserId = userId,
                    IssueReturn = IssueReturntxt.Text.Trim(),
                    StaffId = staffId
                };

                ctx.Reports.Add(report);
                ctx.SaveChanges();
            }

            LoadReports();
            MessageBox.Show("Report added successfully ");

            ClearReportForm();
        }

        private void Report_updatebtn_Click(object sender, EventArgs e)
        {
            if (dgvReports.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            int regNo = (int)dgvReports.CurrentRow.Cells["RegNo"].Value;

            if (!int.TryParse(Book_Notxt.Text.Trim(), out int bookNo) ||
                !int.TryParse(User_IDtxt.Text.Trim(), out int userId) ||
                !int.TryParse(Staff_IDtxt.Text.Trim(), out int staffId))
            {
                MessageBox.Show("Book No, User ID, and Staff ID must be numbers.");
                return;
            }

            using (var ctx = new LmsContext())
            {
                var report = ctx.Reports.FirstOrDefault(r => r.RegNo == regNo);
                if (report == null) return;

                report.BookNo = bookNo;
                report.UserId = userId;
                report.IssueReturn = IssueReturntxt.Text.Trim();
                report.StaffId = staffId;

                ctx.SaveChanges();
            }

            LoadReports();
            MessageBox.Show("Report updated successfully ");
            ClearReportForm();
        }

        private void Report_deletebtn_Click(object sender, EventArgs e)
        {
            if (dgvReports.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            int regNo = (int)dgvReports.CurrentRow.Cells["RegNo"].Value;

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No) return;

            using (var ctx = new LmsContext())
            {
                var report = ctx.Reports.FirstOrDefault(r => r.RegNo == regNo);
                if (report == null)
                {
                    MessageBox.Show("Record not found.");
                    return;
                }

                ctx.Reports.Remove(report);
                ctx.SaveChanges();
            }

            LoadReports();
            MessageBox.Show("🗑 Record deleted successfully ");
            ClearReportForm();
        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvReports.Rows[e.RowIndex];
                Book_Notxt.Text = row.Cells["BookNo"].Value?.ToString();
                User_IDtxt.Text = row.Cells["UserId"].Value?.ToString();
                IssueReturntxt.Text = row.Cells["IssueReturn"].Value?.ToString();
                Staff_IDtxt.Text = row.Cells["StaffId"].Value?.ToString();
            }
        }

        private void ReportSearchtxt_TextChanged(object sender, EventArgs e)
        {
            string searchValue = ReportSearchtxt.Text.Trim().ToLower();

            using (var ctx = new LmsContext())
            {
                var data = ctx.Reports
                    .Where(r => r.IssueReturn.ToLower().Contains(searchValue) ||
                                r.BookNo.ToString().Contains(searchValue) ||
                                r.UserId.ToString().Contains(searchValue))
                    .Select(r => new
                    {
                        r.RegNo,
                        r.BookNo,
                        r.UserId,
                        r.IssueReturn,
                        r.StaffId
                    })
                    .ToList();

                dgvReports.DataSource = data;
            }
        }

        private void Report_clearbtn_Click(object sender, EventArgs e)
        {
            ClearReportForm();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}