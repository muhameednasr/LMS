namespace LMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.ShowDialog();
        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            ReaderForm readerForm = new ReaderForm();
            readerForm.ShowDialog();
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            PublisherForm publisherForm = new PublisherForm();
            publisherForm.ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staff_Form staff = new Staff_Form();
            staff.ShowDialog();
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            Authors_Form authorsForm = new Authors_Form();
            authorsForm.ShowDialog();
        }
    }
}
