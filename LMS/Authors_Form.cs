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
    public partial class Authors_Form : Form
    {
        public Authors_Form()
        {
            InitializeComponent();
            LoadAuthors();
            AuthorSearchtxt.TextChanged += AuthorSearchtxt_TextChanged;

        }

        private void LoadAuthors()
        {
            using (var ctx = new LmsContext())
            {
                var data = ctx.Authors
                    .Select(a => new
                    {
                        a.AuthorId,
                        a.AuthorName,
                        a.Country
                    })
                    .ToList();

                dgvAuthors.DataSource = data;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgvAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvAuthors.Rows[e.RowIndex];

            Authornametxt.Text = row.Cells["AuthorName"].Value?.ToString();
            Authorcountrytxt.Text = row.Cells["Country"].Value?.ToString();
        }

        private void Author_addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Authornametxt.Text))
            {
                MessageBox.Show("Please Add The name of Author");
                return;
            }

            using (var ctx = new LmsContext())
            {
                var author = new Author
                {
                    AuthorName = Authornametxt.Text.Trim(),
                    Country = Authorcountrytxt.Text.Trim()
                };

                ctx.Authors.Add(author);
                ctx.SaveChanges();
            }

            LoadAuthors();
            MessageBox.Show("Author added Successfully");
            Authornametxt.Text = string.Empty;
            Authorcountrytxt.Text = string.Empty;

        }

        private void Author_updatebtn_Click(object sender, EventArgs e)
        {
            if (dgvAuthors.CurrentRow == null) return;

            int id = (int)dgvAuthors.CurrentRow.Cells["AuthorId"].Value;

            using (var ctx = new LmsContext())
            {
                var author = ctx.Authors.FirstOrDefault(a => a.AuthorId == id);
                if (author == null) return;

                author.AuthorName = Authornametxt.Text.Trim();
                author.Country = Authorcountrytxt.Text.Trim();

                ctx.SaveChanges();
            }

            LoadAuthors();
            MessageBox.Show("Data Updated Successfully");
        }

        private void Author_deletebtn_Click(object sender, EventArgs e)
        {
            if (dgvAuthors.CurrentRow == null) return;

            var confirm = MessageBox.Show("Are you sure you want delete this Author", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            int id = (int)dgvAuthors.CurrentRow.Cells["AuthorId"].Value;

            using (var ctx = new LmsContext())
            {
                var author = ctx.Authors.FirstOrDefault(a => a.AuthorId == id);
                if (author != null)
                {
                    ctx.Authors.Remove(author);
                    ctx.SaveChanges();
                }
            }

            LoadAuthors();
            MessageBox.Show("🗑️ Author deleted Successfully");
        }

        private void Author_clearbtn_Click(object sender, EventArgs e)
        {
            Authornametxt.Text = string.Empty;
            Authorcountrytxt.Text = string.Empty;

            // لو عندك حقول تانية، ضيفيها هنا
            Authornametxt.Focus();  // علشان يرجّع المؤشر على أول خانة
        }

        private void AuthorSearchtxt_TextChanged(object sender, EventArgs e)
        {
            string searchValue = AuthorSearchtxt.Text.Trim().ToLower(); // علشان نخلي البحث بدون حساسية للحروف

            using (var ctx = new LmsContext())
            {
                var query = ctx.Authors.AsQueryable();

                if (!string.IsNullOrWhiteSpace(searchValue))
                {
                    query = query.Where(a =>
                        a.AuthorName.ToLower().Contains(searchValue) ||
                        a.Country.ToLower().Contains(searchValue)
                    );
                }

                var data = query
                    .Select(a => new
                    {
                        a.AuthorId,
                        a.AuthorName,
                        a.Country
                    })
                    .ToList();

                dgvAuthors.DataSource = data;
            }
        }
    }
}
