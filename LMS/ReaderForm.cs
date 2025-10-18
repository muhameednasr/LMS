using LMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LMS
{
    public partial class ReaderForm : Form
    {
        public ReaderForm()
        {
            InitializeComponent();
        }

        private void Reader_Load(object sender, EventArgs e)
        {
            using (var context = new LmsContext())
            {
                dgv.DataSource = context.Readers.Select(s => new { UserId = s.UserId, FirstName =s.FirstName,LastName=s.LastName,Name=s.Name,Email=s.Email, PhoneNo=s.PhoneNo, Address=s.Address}).ToList();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text)
                )
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }

            using (var context = new LmsContext())
            {
                var reader = new Reader()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Name = txtFirstName.Text + ' ' + txtLastName.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    PhoneNo = txtPhone.Text,
                };
                context.Readers.Add(reader);
                context.SaveChanges();
            }
            MessageBox.Show("reader added successfully!");
            Reader_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedReader == 0)
            {
                MessageBox.Show("Please select a book to update.");
                return;
            }
            using (var context = new LmsContext())
            {
                var reader = context.Readers.FirstOrDefault(x => x.UserId == selectedReader);

                reader.FirstName = txtFirstName.Text;
                reader.LastName = txtLastName.Text;
                reader.Name = txtFirstName.Text + ' ' + txtLastName.Text;
                reader.Email = txtEmail.Text;
                reader.Address = txtAddress.Text;
                reader.PhoneNo = txtPhone.Text;

                context.SaveChanges();
            }
            MessageBox.Show("reader updated successfully!");
            Reader_Load(sender, e);
        }

        int selectedReader = 0;
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv.Rows[e.RowIndex];
                selectedReader = int.Parse(row.Cells["UserId"].Value.ToString());
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtPhone.Text = row.Cells["PhoneNo"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedReader == 0)
            {
                MessageBox.Show("Please select a reader to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this reader?",
                                          "Confirm Delete",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (confirm == DialogResult.No)
                return;

            using (var context = new LmsContext())
            {
                var reader = context.Readers.FirstOrDefault(b => b.UserId == selectedReader);

                context.Readers.Remove(reader);
                context.SaveChanges();
            }

            MessageBox.Show("reader deleted successfully!");
            selectedReader = 0;
            Reader_Load(sender, e);
        }
    }
}
