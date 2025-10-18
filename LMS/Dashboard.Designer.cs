namespace LMS
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            pictureBox1 = new PictureBox();
            btnBooks = new Button();
            btnReader = new Button();
            btnStaff = new Button();
            btnPublisher = new Button();
            btnAuthors = new Button();
            btnReports = new Button();
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pexels_joshkjack_135018;
            pictureBox1.Location = new Point(-156, -28);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1153, 593);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnBooks
            // 
            btnBooks.BackgroundImage = (Image)resources.GetObject("btnBooks.BackgroundImage");
            btnBooks.BackgroundImageLayout = ImageLayout.Stretch;
            btnBooks.FlatStyle = FlatStyle.Popup;
            btnBooks.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooks.ForeColor = SystemColors.ButtonHighlight;
            btnBooks.Location = new Point(-3, -16);
            btnBooks.Margin = new Padding(3, 2, 3, 2);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(196, 170);
            btnBooks.TabIndex = 1;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnReader
            // 
            btnReader.BackgroundImage = (Image)resources.GetObject("btnReader.BackgroundImage");
            btnReader.BackgroundImageLayout = ImageLayout.Stretch;
            btnReader.FlatStyle = FlatStyle.Popup;
            btnReader.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReader.ForeColor = SystemColors.ButtonHighlight;
            btnReader.Location = new Point(-3, 148);
            btnReader.Margin = new Padding(3, 2, 3, 2);
            btnReader.Name = "btnReader";
            btnReader.Size = new Size(193, 209);
            btnReader.TabIndex = 2;
            btnReader.Text = "Reader";
            btnReader.UseVisualStyleBackColor = true;
            btnReader.Click += btnReader_Click;
            // 
            // btnStaff
            // 
            btnStaff.BackgroundImage = (Image)resources.GetObject("btnStaff.BackgroundImage");
            btnStaff.BackgroundImageLayout = ImageLayout.Stretch;
            btnStaff.FlatStyle = FlatStyle.Popup;
            btnStaff.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaff.ForeColor = SystemColors.ButtonHighlight;
            btnStaff.Location = new Point(5, 361);
            btnStaff.Margin = new Padding(3, 2, 3, 2);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(156, 115);
            btnStaff.TabIndex = 3;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnPublisher
            // 
            btnPublisher.BackgroundImage = (Image)resources.GetObject("btnPublisher.BackgroundImage");
            btnPublisher.BackgroundImageLayout = ImageLayout.Stretch;
            btnPublisher.FlatStyle = FlatStyle.Popup;
            btnPublisher.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPublisher.ForeColor = SystemColors.ButtonHighlight;
            btnPublisher.Location = new Point(695, -2);
            btnPublisher.Margin = new Padding(3, 2, 3, 2);
            btnPublisher.Name = "btnPublisher";
            btnPublisher.Size = new Size(173, 156);
            btnPublisher.TabIndex = 4;
            btnPublisher.Text = "Publisher";
            btnPublisher.UseVisualStyleBackColor = true;
            btnPublisher.Click += btnPublisher_Click;
            // 
            // btnAuthors
            // 
            btnAuthors.BackgroundImage = (Image)resources.GetObject("btnAuthors.BackgroundImage");
            btnAuthors.BackgroundImageLayout = ImageLayout.Stretch;
            btnAuthors.FlatStyle = FlatStyle.Popup;
            btnAuthors.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAuthors.ForeColor = SystemColors.ButtonHighlight;
            btnAuthors.Location = new Point(620, 158);
            btnAuthors.Margin = new Padding(3, 2, 3, 2);
            btnAuthors.Name = "btnAuthors";
            btnAuthors.Size = new Size(248, 209);
            btnAuthors.TabIndex = 5;
            btnAuthors.Text = "Authors";
            btnAuthors.UseVisualStyleBackColor = true;
            btnAuthors.Click += btnAuthors_Click;
            // 
            // btnReports
            // 
            btnReports.BackgroundImage = (Image)resources.GetObject("btnReports.BackgroundImage");
            btnReports.BackgroundImageLayout = ImageLayout.Stretch;
            btnReports.FlatStyle = FlatStyle.Popup;
            btnReports.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = SystemColors.ButtonHighlight;
            btnReports.Location = new Point(675, 423);
            btnReports.Margin = new Padding(3, 2, 3, 2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(183, 142);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 564);
            Controls.Add(btnReports);
            Controls.Add(btnAuthors);
            Controls.Add(btnPublisher);
            Controls.Add(btnStaff);
            Controls.Add(btnReader);
            Controls.Add(btnBooks);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnBooks;
        private Button btnReader;
        private Button btnStaff;
        private Button btnPublisher;
        private Button btnAuthors;
        private Button btnReports;
        private NotifyIcon notifyIcon1;
    }
}
