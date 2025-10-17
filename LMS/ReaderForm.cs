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
    public partial class ReaderForm : Form
    {
        public ReaderForm()
        {
            InitializeComponent();
        }

        private void Reader_Load(object sender, EventArgs e)
        {
            using(var context = new LmsContext())
            {
                dgv.DataSource = context.Readers.ToList();
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

        
    }
}
