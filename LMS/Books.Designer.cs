namespace LMS
{
    partial class Books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv = new DataGridView();
            label1 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            label2 = new Label();
            txtTitle = new TextBox();
            txtEdition = new TextBox();
            label3 = new Label();
            txtCategory = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboAuthor = new ComboBox();
            comboPublisher = new ComboBox();
            label7 = new Label();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ButtonHighlight;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.GridColor = SystemColors.InactiveBorder;
            dgv.Location = new Point(-1, 73);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(844, 563);
            dgv.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.Firebrick;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.icons8_folder_60;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1041, 46);
            label1.TabIndex = 1;
            label1.Text = "Books";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HotTrack;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(878, 545);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 37);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(953, 599);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(76, 37);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(929, 81);
            label2.Name = "label2";
            label2.Size = new Size(49, 31);
            label2.TabIndex = 4;
            label2.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(879, 120);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(149, 27);
            txtTitle.TabIndex = 5;
            // 
            // txtEdition
            // 
            txtEdition.Location = new Point(879, 194);
            txtEdition.Name = "txtEdition";
            txtEdition.Size = new Size(149, 27);
            txtEdition.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(919, 155);
            label3.Name = "label3";
            label3.Size = new Size(69, 31);
            label3.TabIndex = 6;
            label3.Text = "Edition";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(879, 268);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(149, 27);
            txtCategory.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(912, 229);
            label4.Name = "label4";
            label4.Size = new Size(83, 31);
            label4.TabIndex = 8;
            label4.Text = "Category";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(879, 342);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(149, 27);
            txtPrice.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(927, 303);
            label5.Name = "label5";
            label5.Size = new Size(52, 31);
            label5.TabIndex = 10;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(920, 377);
            label6.Name = "label6";
            label6.Size = new Size(67, 31);
            label6.TabIndex = 12;
            label6.Text = "Author";
            label6.Click += label6_Click;
            // 
            // comboAuthor
            // 
            comboAuthor.FormattingEnabled = true;
            comboAuthor.Location = new Point(878, 416);
            comboAuthor.Name = "comboAuthor";
            comboAuthor.Size = new Size(151, 28);
            comboAuthor.TabIndex = 13;
            // 
            // comboPublisher
            // 
            comboPublisher.FormattingEnabled = true;
            comboPublisher.Location = new Point(878, 491);
            comboPublisher.Name = "comboPublisher";
            comboPublisher.Size = new Size(151, 28);
            comboPublisher.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(910, 452);
            label7.Name = "label7";
            label7.Size = new Size(86, 31);
            label7.TabIndex = 14;
            label7.Text = "Publisher";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkOliveGreen;
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(878, 599);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(76, 37);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1076, 661);
            Controls.Add(btnUpdate);
            Controls.Add(comboPublisher);
            Controls.Add(label7);
            Controls.Add(comboAuthor);
            Controls.Add(label6);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(txtCategory);
            Controls.Add(label4);
            Controls.Add(txtEdition);
            Controls.Add(label3);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(dgv);
            Name = "Books";
            Text = "Books";
            Load += Books_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Label label1;
        private Button btnAdd;
        private Button btnDelete;
        private Label label2;
        private TextBox txtTitle;
        private TextBox txtEdition;
        private Label label3;
        private TextBox txtCategory;
        private Label label4;
        private TextBox txtPrice;
        private Label label5;
        private Label label6;
        private ComboBox comboAuthor;
        private ComboBox comboPublisher;
        private Label label7;
        private Button btnUpdate;
    }
}