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
                      Title = b.Title,
                      Edition = b.Edition,
                      Category = b.Category,
                      Price = b.Price,
                      Autor = a.AuthorName,
                      publisherId=b.PublisherId,
                      staffId=b.StaffId,
                  }).Join(
                    context.Publishers,
                    ba=>ba.publisherId,
                    p=>p.PublisherId,
                    (ba, p) => new
                    {
                        Title = ba.Title,
                        Edition = ba.Edition,
                        Category = ba.Category,
                        Price = ba.Price,
                        Autor = ba.Autor,
                        staffId=ba.staffId,
                        publisherName=p.Name
                    }).Join(
                    context.Staff,
                    b=>b.staffId,
                    s=>s.StaffId,
                    (b, s) => new
                    {
                        Title = b.Title,
                        Edition = b.Edition,
                        Category = b.Category,
                        Price = b.Price,
                        Autor = b.Autor,
                        publisher=b.publisherName,
                        staff=s.Name
                    })
                    .ToList();
            }
        }
    }
}
