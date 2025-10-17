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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            pictureBox1 = new PictureBox();
            btnBooks = new Button();
            btnReader = new Button();
            btnStaff = new Button();
            btnPublisher = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pexels_joshkjack_135018;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(696, 336);
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
            btnBooks.Location = new Point(117, 2);
            btnBooks.Margin = new Padding(3, 2, 3, 2);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(88, 75);
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
            btnReader.Location = new Point(99, 104);
            btnReader.Margin = new Padding(3, 2, 3, 2);
            btnReader.Name = "btnReader";
            btnReader.Size = new Size(88, 75);
            btnReader.TabIndex = 2;
            btnReader.Text = "Reader";
            btnReader.UseVisualStyleBackColor = true;
            // 
            // btnStaff
            // 
            btnStaff.BackgroundImage = (Image)resources.GetObject("btnStaff.BackgroundImage");
            btnStaff.BackgroundImageLayout = ImageLayout.Stretch;
            btnStaff.FlatStyle = FlatStyle.Popup;
            btnStaff.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaff.ForeColor = SystemColors.ButtonHighlight;
            btnStaff.Location = new Point(117, 222);
            btnStaff.Margin = new Padding(3, 2, 3, 2);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(88, 75);
            btnStaff.TabIndex = 3;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnPublisher
            // 
            btnPublisher.BackgroundImage = (Image)resources.GetObject("btnPublisher.BackgroundImage");
            btnPublisher.BackgroundImageLayout = ImageLayout.Stretch;
            btnPublisher.FlatStyle = FlatStyle.Popup;
            btnPublisher.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPublisher.ForeColor = SystemColors.ButtonHighlight;
            btnPublisher.Location = new Point(471, 3);
            btnPublisher.Margin = new Padding(3, 2, 3, 2);
            btnPublisher.Name = "btnPublisher";
            btnPublisher.Size = new Size(122, 90);
            btnPublisher.TabIndex = 4;
            btnPublisher.Text = "Publisher";
            btnPublisher.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnPublisher);
            Controls.Add(btnStaff);
            Controls.Add(btnReader);
            Controls.Add(btnBooks);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dashboard";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnBooks;
        private Button btnReader;
        private Button btnStaff;
        private Button btnPublisher;
    }
}
