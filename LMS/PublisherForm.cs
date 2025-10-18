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
    public partial class PublisherForm : Form
    {
        public PublisherForm()
        {
            InitializeComponent();
        }

        private void PublisherForm_Load(object sender, EventArgs e)
        {
            using (var context = new LmsContext())
            {

                dgv.DataSource = context.Publishers.Select(s => new { Id = s.PublisherId, Name = s.Name, YearOfProduction = s.YearOfPublication }).ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                !int.TryParse(txtYear.Text, out int year)
                || year > DateTime.Now.Year)
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }

            using (var context = new LmsContext())
            {
                var publisher = new Publisher()
                {
                    Name = txtName.Text,
                    YearOfPublication = year

                };
                context.Publishers.Add(publisher);
                context.SaveChanges();
            }
            MessageBox.Show("publisher added successfully!");
            PublisherForm_Load(sender, e);
        }

        int selectedPublisher = 0;
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv.Rows[e.RowIndex];
                selectedPublisher = int.Parse(row.Cells["Id"].Value.ToString());
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtYear.Text = row.Cells["YearOfProduction"].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPublisher == 0)
            {
                MessageBox.Show("Please select a Publisher to update.");
                return;
            }
            using (var context = new LmsContext())
            {
                var publisher = context.Publishers.FirstOrDefault(x => x.PublisherId == selectedPublisher);

                publisher.Name = txtName.Text;
                publisher.YearOfPublication = int.Parse(txtYear.Text);

                context.SaveChanges();
            }
            MessageBox.Show("Publisher updated successfully!");
            PublisherForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPublisher == 0)
            {
                MessageBox.Show("Please select a publisher to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this publisher?",
                                          "Confirm Delete",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (confirm == DialogResult.No)
                return;

            using (var context = new LmsContext())
            {
                var publisher = context.Publishers.FirstOrDefault(x => x.PublisherId == selectedPublisher);

                context.Publishers.Remove(publisher);
                context.SaveChanges();
            }

            MessageBox.Show("publisher deleted successfully!");
            selectedPublisher = 0;
            PublisherForm_Load(sender, e);
        }
    }
}


