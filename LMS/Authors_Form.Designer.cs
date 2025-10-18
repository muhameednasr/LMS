namespace LMS
{
    partial class Authors_Form
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
            Author_addbtn = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dgvAuthors = new DataGridView();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            Author_deletebtn = new Button();
            Author_clearbtn = new Button();
            Author_updatebtn = new Button();
            Authorcountrytxt = new TextBox();
            Authornametxt = new TextBox();
            AuthorSearchtxt = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // Author_addbtn
            // 
            Author_addbtn.BackColor = Color.FromArgb(7, 13, 45);
            Author_addbtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Author_addbtn.ForeColor = Color.White;
            Author_addbtn.Location = new Point(20, 320);
            Author_addbtn.Name = "Author_addbtn";
            Author_addbtn.Size = new Size(169, 37);
            Author_addbtn.TabIndex = 2;
            Author_addbtn.Text = "Add";
            Author_addbtn.UseVisualStyleBackColor = false;
            Author_addbtn.Click += Author_addbtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 13, 45);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1360, 69);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1312, 23);
            label4.Name = "label4";
            label4.Size = new Size(21, 22);
            label4.TabIndex = 1;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(529, 23);
            label1.Name = "label1";
            label1.Size = new Size(124, 22);
            label1.TabIndex = 0;
            label1.Text = "Author Page";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvAuthors);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1360, 630);
            panel2.TabIndex = 3;
            // 
            // dgvAuthors
            // 
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthors.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvAuthors.Location = new Point(46, 123);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.ReadOnly = true;
            dgvAuthors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuthors.Size = new Size(794, 439);
            dgvAuthors.TabIndex = 2;
            dgvAuthors.CellContentClick += dgvAuthors_CellContentClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Controls.Add(AuthorSearchtxt);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(Author_deletebtn);
            panel4.Controls.Add(Author_clearbtn);
            panel4.Controls.Add(Author_updatebtn);
            panel4.Controls.Add(Author_addbtn);
            panel4.Controls.Add(Authorcountrytxt);
            panel4.Controls.Add(Authornametxt);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(903, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(457, 630);
            panel4.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(7, 13, 45);
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(53, 166);
            label3.Name = "label3";
            label3.Size = new Size(82, 22);
            label3.TabIndex = 7;
            label3.Text = "Country";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(7, 13, 45);
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 95);
            label2.Name = "label2";
            label2.Size = new Size(130, 22);
            label2.TabIndex = 1;
            label2.Text = "Author Name";
            // 
            // Author_deletebtn
            // 
            Author_deletebtn.BackColor = Color.FromArgb(7, 13, 45);
            Author_deletebtn.Font = new Font("Arial Rounded MT Bold", 11.25F);
            Author_deletebtn.ForeColor = Color.White;
            Author_deletebtn.Location = new Point(219, 401);
            Author_deletebtn.Name = "Author_deletebtn";
            Author_deletebtn.Size = new Size(169, 37);
            Author_deletebtn.TabIndex = 5;
            Author_deletebtn.Text = "Delete";
            Author_deletebtn.UseVisualStyleBackColor = false;
            Author_deletebtn.Click += Author_deletebtn_Click;
            // 
            // Author_clearbtn
            // 
            Author_clearbtn.BackColor = Color.FromArgb(7, 13, 45);
            Author_clearbtn.Font = new Font("Arial Rounded MT Bold", 11.25F);
            Author_clearbtn.ForeColor = Color.White;
            Author_clearbtn.Location = new Point(20, 401);
            Author_clearbtn.Name = "Author_clearbtn";
            Author_clearbtn.Size = new Size(169, 37);
            Author_clearbtn.TabIndex = 4;
            Author_clearbtn.Text = "Clear";
            Author_clearbtn.UseVisualStyleBackColor = false;
            Author_clearbtn.Click += Author_clearbtn_Click;
            // 
            // Author_updatebtn
            // 
            Author_updatebtn.BackColor = Color.FromArgb(7, 13, 45);
            Author_updatebtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Author_updatebtn.ForeColor = Color.White;
            Author_updatebtn.Location = new Point(219, 320);
            Author_updatebtn.Name = "Author_updatebtn";
            Author_updatebtn.Size = new Size(169, 37);
            Author_updatebtn.TabIndex = 3;
            Author_updatebtn.Text = "Update";
            Author_updatebtn.UseVisualStyleBackColor = false;
            Author_updatebtn.Click += Author_updatebtn_Click;
            // 
            // Authorcountrytxt
            // 
            Authorcountrytxt.Location = new Point(180, 165);
            Authorcountrytxt.Name = "Authorcountrytxt";
            Authorcountrytxt.Size = new Size(208, 23);
            Authorcountrytxt.TabIndex = 1;
            // 
            // Authornametxt
            // 
            Authornametxt.Location = new Point(180, 94);
            Authornametxt.Name = "Authornametxt";
            Authornametxt.Size = new Size(208, 23);
            Authornametxt.TabIndex = 0;
            // 
            // AuthorSearchtxt
            // 
            AuthorSearchtxt.Location = new Point(180, 525);
            AuthorSearchtxt.Name = "AuthorSearchtxt";
            AuthorSearchtxt.Size = new Size(208, 23);
            AuthorSearchtxt.TabIndex = 8;
            AuthorSearchtxt.TextChanged += AuthorSearchtxt_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(7, 13, 45);
            label6.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(53, 525);
            label6.Name = "label6";
            label6.Size = new Size(75, 22);
            label6.TabIndex = 10;
            label6.Text = "Saerch";
            // 
            // Authors_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 630);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Authors_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authors_Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Author_addbtn;
        private Panel panel1;
        private Label label4;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvAuthors;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private Button Author_deletebtn;
        private Button Author_clearbtn;
        private Button Author_updatebtn;
        private TextBox Authorcountrytxt;
        private TextBox Authornametxt;
        private Label label6;
        private TextBox AuthorSearchtxt;
    }
}