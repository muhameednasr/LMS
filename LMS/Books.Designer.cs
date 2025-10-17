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
            dgv.Location = new Point(-1, 55);
            dgv.Margin = new Padding(3, 2, 3, 2);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(738, 422);
            dgv.TabIndex = 0;
            dgv.CellClick += dgv_CellClick;
            // 
            // label1
            // 
            label1.BackColor = Color.Firebrick;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.icons8_folder_60;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(911, 34);
            label1.TabIndex = 1;
            label1.Text = "Books";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HotTrack;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(768, 409);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 28);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(834, 449);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(66, 28);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(813, 61);
            label2.Name = "label2";
            label2.Size = new Size(40, 25);
            label2.TabIndex = 4;
            label2.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(769, 90);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(131, 23);
            txtTitle.TabIndex = 5;
            // 
            // txtEdition
            // 
            txtEdition.Location = new Point(769, 146);
            txtEdition.Margin = new Padding(3, 2, 3, 2);
            txtEdition.Name = "txtEdition";
            txtEdition.Size = new Size(131, 23);
            txtEdition.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(804, 116);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 6;
            label3.Text = "Edition";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(769, 201);
            txtCategory.Margin = new Padding(3, 2, 3, 2);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(131, 23);
            txtCategory.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(798, 172);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 8;
            label4.Text = "Category";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(769, 256);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(131, 23);
            txtPrice.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(811, 227);
            label5.Name = "label5";
            label5.Size = new Size(43, 25);
            label5.TabIndex = 10;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(805, 283);
            label6.Name = "label6";
            label6.Size = new Size(55, 25);
            label6.TabIndex = 12;
            label6.Text = "Author";
            label6.Click += label6_Click;
            // 
            // comboAuthor
            // 
            comboAuthor.FormattingEnabled = true;
            comboAuthor.Location = new Point(768, 312);
            comboAuthor.Margin = new Padding(3, 2, 3, 2);
            comboAuthor.Name = "comboAuthor";
            comboAuthor.Size = new Size(133, 23);
            comboAuthor.TabIndex = 13;
            // 
            // comboPublisher
            // 
            comboPublisher.FormattingEnabled = true;
            comboPublisher.Location = new Point(768, 368);
            comboPublisher.Margin = new Padding(3, 2, 3, 2);
            comboPublisher.Name = "comboPublisher";
            comboPublisher.Size = new Size(133, 23);
            comboPublisher.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(796, 339);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 14;
            label7.Text = "Publisher";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkOliveGreen;
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(768, 449);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(66, 28);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(942, 496);
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
            Margin = new Padding(3, 2, 3, 2);
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