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
    }
}
