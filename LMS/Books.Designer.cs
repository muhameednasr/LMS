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
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
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
            dgv.Size = new Size(666, 449);
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
            label1.Size = new Size(808, 46);
            label1.TabIndex = 1;
            label1.Text = "Books";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Firebrick;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(682, 437);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(149, 37);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(682, 485);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 37);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(682, 83);
            label2.Name = "label2";
            label2.Size = new Size(49, 31);
            label2.TabIndex = 4;
            label2.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(682, 117);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(682, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(682, 165);
            label3.Name = "label3";
            label3.Size = new Size(49, 31);
            label3.TabIndex = 6;
            label3.Text = "Title";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(682, 278);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(682, 244);
            label4.Name = "label4";
            label4.Size = new Size(49, 31);
            label4.TabIndex = 8;
            label4.Text = "Title";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(682, 354);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(682, 320);
            label5.Name = "label5";
            label5.Size = new Size(49, 31);
            label5.TabIndex = 10;
            label5.Text = "Title";
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(858, 534);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
    }
}