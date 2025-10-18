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
using System.Xml.Linq;

namespace LMS
{
    public partial class Staff_Form : Form
    {
        public Staff_Form()
        {
            InitializeComponent();
            LoadStaff();
        }
        private void LoadStaff()
        {
            using (var ctx = new LmsContext())
            {
                var data = ctx.Staff
                    .Select(s => new
                    {
                        s.StaffId,
                        s.Name,
                        s.LoginId
                    })
                    .ToList();

                dgvStaff.DataSource = data;
            }
        }

        private void Staff_addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Staffnametxt.Text) || string.IsNullOrWhiteSpace(StaffloginIdtxt.Text))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            if (!int.TryParse(StaffloginIdtxt.Text.Trim(), out int loginId))
            {
                MessageBox.Show("Login ID must be a number");
                return;
            }

            using (var ctx = new LmsContext())
            {
                var staff = new Staff
                {
                    Name = Staffnametxt.Text.Trim(),
                    LoginId = loginId   
                };

                ctx.Staff.Add(staff);
                ctx.SaveChanges();
            }

            LoadStaff();
            MessageBox.Show("Staff added successfully ");

            Staffnametxt.Text = string.Empty;
            StaffloginIdtxt.Text = string.Empty;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Staff_updatebtn_Click(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            int id = (int)dgvStaff.CurrentRow.Cells["StaffId"].Value;

            using (var ctx = new LmsContext())
            {
                var staff = ctx.Staff.FirstOrDefault(s => s.StaffId == id);
                if (staff == null)
                {
                    MessageBox.Show("Record not found.");
                    return;
                }

                // تعديل القيم من الـ TextBox
                staff.Name = Staffnametxt.Text.Trim();

                if (int.TryParse(StaffloginIdtxt.Text.Trim(), out int loginId))
                {
                    staff.LoginId = loginId;
                }
                else
                {
                    MessageBox.Show("Login ID must be a number.");
                    return;
                }

                ctx.SaveChanges();
            }


            LoadStaff();
            MessageBox.Show("Staff updated successfully");
            Staffnametxt.Text = string.Empty;
            StaffloginIdtxt.Text = string.Empty;

        }

        private void Staff_clearbtn_Click(object sender, EventArgs e)
        {
            Staffnametxt.Text = string.Empty;
            StaffloginIdtxt.Text = string.Empty;

            Staffnametxt.Focus();
        }

        private void Staff_deletebtn_Click(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow == null) return;

            int id = (int)dgvStaff.CurrentRow.Cells["StaffId"].Value;

            using (var ctx = new LmsContext())
            {
                var staff = ctx.Staff.FirstOrDefault(s => s.StaffId == id);
                if (staff == null) return;

                ctx.Staff.Remove(staff);
                ctx.SaveChanges();
            }

            LoadStaff();
            MessageBox.Show("🗑️ Staff member deleted Successfully");
            Staffnametxt.Text = string.Empty;
            StaffloginIdtxt.Text = string.Empty;

        }

        private void StaffSearchtxt_TextChanged(object sender, EventArgs e)
        {
            string searchValue = StaffSearchtxt.Text.Trim().ToLower();

            using (var ctx = new LmsContext())
            {
                var query = ctx.Staff.AsQueryable();

                if (!string.IsNullOrWhiteSpace(searchValue))
                {
                    query = query.Where(s =>
                        (s.Name ?? "").ToLower().Contains(searchValue) ||
                        (s.LoginId.HasValue ? s.LoginId.Value.ToString() : "").ToLower().Contains(searchValue)
                    );
                }

                var data = query
                    .Select(s => new
                    {
                        s.StaffId,
                        s.Name,
                        s.LoginId
                    })
                    .ToList();

                dgvStaff.DataSource = data;
            }
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStaff.CurrentRow == null) return;

            Staffnametxt.Text = dgvStaff.CurrentRow.Cells["Name"].Value?.ToString();
            StaffloginIdtxt.Text = dgvStaff.CurrentRow.Cells["LoginId"].Value?.ToString();
        }
    }
}
