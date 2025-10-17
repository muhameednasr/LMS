using LMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            using (var context = new LmsContext())
            {
                dgv.DataSource = context.Books.Join(
                  context.Authors,
                  books => books.AuthorId,
                  authors => authors.AuthorId,
                  (b, a) => new
                  {
                      bookId = b.Isbn,
                      Title = b.Title,
                      Edition = b.Edition,
                      Category = b.Category,
                      Price = b.Price,
                      Autor = a.AuthorName,
                      AuthorId = a.AuthorId,
                      publisherId = b.PublisherId,
                      staffId = b.StaffId,
                  }).Join(
                    context.Publishers,
                    ba => ba.publisherId,
                    p => p.PublisherId,
                    (ba, p) => new
                    {
                        bookId = ba.bookId,
                        Title = ba.Title,
                        Edition = ba.Edition,
                        Category = ba.Category,
                        Price = ba.Price,
                        Autor = ba.Autor,
                        AuthorId = ba.AuthorId,
                        staffId = ba.staffId,
                        publisherName = p.Name,
                        PublisherId = p.PublisherId
                    }).Join(
                    context.Staff,
                    b => b.staffId,
                    s => s.StaffId,
                    (b, s) => new
                    {
                        bookId = b.bookId,
                        Title = b.Title,
                        Edition = b.Edition,
                        Category = b.Category,
                        Price = b.Price,
                        Autor = b.Autor,
                        AuthorId = b.AuthorId,
                        publisher = b.publisherName,
                        PublisherId = b.PublisherId,
                        staff = s.Name
                    })
                    .ToList();

                dgv.Columns["bookId"].Visible = false;
                dgv.Columns["AuthorId"].Visible = false;
                dgv.Columns["PublisherId"].Visible = false;
                comboAuthor.DataSource = context.Authors.ToList();
                comboAuthor.DisplayMember = "AuthorName";
                comboAuthor.ValueMember = "AuthorId";

                comboPublisher.DataSource = context.Publishers.ToList();
                comboPublisher.DisplayMember = "Name";
                comboPublisher.ValueMember = "PublisherId";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtEdition.Text) ||
                string.IsNullOrWhiteSpace(txtCategory.Text) ||
                !decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }

            using (var context = new LmsContext())
            {
                var book = new Book()
                {
                    Title = txtTitle.Text,
                    Edition = txtEdition.Text,
                    Category = txtCategory.Text,
                    Price = price,
                    AuthorId = (int)comboAuthor.SelectedValue,
                    PublisherId = (int)comboPublisher.SelectedValue,
                    StaffId = staticUser.staffId

                };

                context.Books.Add(book);
                context.SaveChanges();
            }

            MessageBox.Show("Book added successfully!");
            Books_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedBookId == 0)
            {
                MessageBox.Show("Please select a book to update.");
                return;
            }

            using (var context = new LmsContext())
            {
                var book = context.Books.FirstOrDefault(b => b.Isbn == selectedBookId);

                if (book == null)
                {
                    MessageBox.Show("Book not found!");
                    return;
                }

                book.Title = txtTitle.Text;
                book.Edition = txtEdition.Text;
                book.Category = txtCategory.Text;
                book.Price = decimal.Parse(txtPrice.Text);
                book.AuthorId = (int)comboAuthor.SelectedValue;
                book.PublisherId = (int)comboPublisher.SelectedValue;
                book.StaffId = staticUser.staffId;

                context.SaveChanges();
            }

            MessageBox.Show("Book updated successfully!");
            Books_Load(sender, e);

        }

        int selectedBookId = 0;

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgv.Rows[e.RowIndex];
                selectedBookId = Convert.ToInt32(row.Cells["bookId"].Value);


                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtEdition.Text = row.Cells["Edition"].Value.ToString();
                txtCategory.Text = row.Cells["Category"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                comboAuthor.SelectedValue = Convert.ToInt32(row.Cells["AuthorId"].Value);
                comboPublisher.SelectedValue = Convert.ToInt32(row.Cells["PublisherId"].Value);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedBookId == 0)
            {
                MessageBox.Show("Please select a book to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this book?",
                                          "Confirm Delete",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (confirm == DialogResult.No)
                return;

            using (var context = new LmsContext())
            {
                var book = context.Books.FirstOrDefault(b => b.Isbn == selectedBookId);

                context.Books.Remove(book);
                context.SaveChanges();
            }

            MessageBox.Show("Book deleted successfully!");
            selectedBookId = 0; 
            Books_Load(sender, e); 
        }

    }
}
