using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using Font = System.Drawing.Font;

namespace LMS
{
    partial class Reports_Form
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
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            ReportSearchtxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Report_deletebtn = new Button();
            Report_clearbtn = new Button();
            Report_updatebtn = new Button();
            Report_addbtn = new Button();
            Book_Notxt = new TextBox();
            dgvReports = new DataGridView();
            panel4 = new Panel();
            IssueReturntxt = new TextBox();
            Staff_IDtxt = new TextBox();
            User_IDtxt = new TextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(422, 18);
            label1.Name = "label1";
            label1.Size = new Size(125, 22);
            label1.TabIndex = 0;
            label1.Text = "Report Page";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 56);
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(996, 18);
            label4.Name = "label4";
            label4.Size = new Size(21, 22);
            label4.TabIndex = 1;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(68, 284);
            label5.Name = "label5";
            label5.Size = new Size(83, 22);
            label5.TabIndex = 14;
            label5.Text = "Staff_ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(31, 330);
            label7.Name = "label7";
            label7.Size = new Size(120, 22);
            label7.TabIndex = 12;
            label7.Text = "IssueReturn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(78, 391);
            label6.Name = "label6";
            label6.Size = new Size(75, 22);
            label6.TabIndex = 10;
            label6.Text = "Saerch";
            // 
            // ReportSearchtxt
            // 
            ReportSearchtxt.Location = new Point(205, 391);
            ReportSearchtxt.Name = "ReportSearchtxt";
            ReportSearchtxt.Size = new Size(208, 23);
            ReportSearchtxt.TabIndex = 8;
            ReportSearchtxt.TextChanged += ReportSearchtxt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(68, 228);
            label3.Name = "label3";
            label3.Size = new Size(83, 22);
            label3.TabIndex = 7;
            label3.Text = "User_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(59, 172);
            label2.Name = "label2";
            label2.Size = new Size(92, 22);
            label2.TabIndex = 1;
            label2.Text = "Book_No";
            // 
            // Report_deletebtn
            // 
            Report_deletebtn.BackColor = Color.Firebrick;
            Report_deletebtn.Font = new Font("Arial Rounded MT Bold", 11.25F);
            Report_deletebtn.ForeColor = Color.White;
            Report_deletebtn.Location = new Point(280, 567);
            Report_deletebtn.Name = "Report_deletebtn";
            Report_deletebtn.Size = new Size(169, 37);
            Report_deletebtn.TabIndex = 5;
            Report_deletebtn.Text = "Delete";
            Report_deletebtn.UseVisualStyleBackColor = false;
            Report_deletebtn.Click += Report_deletebtn_Click;
            // 
            // Report_clearbtn
            // 
            Report_clearbtn.BackColor = Color.FromArgb(7, 13, 45);
            Report_clearbtn.Font = new Font("Arial Rounded MT Bold", 11.25F);
            Report_clearbtn.ForeColor = Color.White;
            Report_clearbtn.Location = new Point(81, 567);
            Report_clearbtn.Name = "Report_clearbtn";
            Report_clearbtn.Size = new Size(169, 37);
            Report_clearbtn.TabIndex = 4;
            Report_clearbtn.Text = "Clear";
            Report_clearbtn.UseVisualStyleBackColor = false;
            Report_clearbtn.Click += Report_clearbtn_Click;
            // 
            // Report_updatebtn
            // 
            Report_updatebtn.BackColor = Color.DarkOliveGreen;
            Report_updatebtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Report_updatebtn.ForeColor = Color.White;
            Report_updatebtn.Location = new Point(280, 486);
            Report_updatebtn.Name = "Report_updatebtn";
            Report_updatebtn.Size = new Size(169, 37);
            Report_updatebtn.TabIndex = 3;
            Report_updatebtn.Text = "Update";
            Report_updatebtn.UseVisualStyleBackColor = false;
            Report_updatebtn.Click += Report_updatebtn_Click;
            // 
            // Report_addbtn
            // 
            Report_addbtn.BackColor = SystemColors.HotTrack;
            Report_addbtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Report_addbtn.ForeColor = Color.White;
            Report_addbtn.Location = new Point(81, 486);
            Report_addbtn.Name = "Report_addbtn";
            Report_addbtn.Size = new Size(169, 37);
            Report_addbtn.TabIndex = 2;
            Report_addbtn.Text = "Add";
            Report_addbtn.UseVisualStyleBackColor = false;
            Report_addbtn.Click += Report_addbtn_Click;
            // 
            // Book_Notxt
            // 
            Book_Notxt.Location = new Point(205, 175);
            Book_Notxt.Name = "Book_Notxt";
            Book_Notxt.Size = new Size(208, 23);
            Book_Notxt.TabIndex = 0;
            // 
            // dgvReports
            // 
            dgvReports.BackgroundColor = SystemColors.ButtonHighlight;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvReports.Location = new Point(11, 161);
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.Size = new Size(536, 253);
            dgvReports.TabIndex = 2;
            dgvReports.CellContentClick += dgvReports_CellContentClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(IssueReturntxt);
            panel4.Controls.Add(Staff_IDtxt);
            panel4.Controls.Add(User_IDtxt);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(ReportSearchtxt);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(Book_Notxt);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(574, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(455, 686);
            panel4.TabIndex = 1;
            // 
            // IssueReturntxt
            // 
            IssueReturntxt.Location = new Point(205, 333);
            IssueReturntxt.Name = "IssueReturntxt";
            IssueReturntxt.Size = new Size(208, 23);
            IssueReturntxt.TabIndex = 17;
            // 
            // Staff_IDtxt
            // 
            Staff_IDtxt.Location = new Point(205, 287);
            Staff_IDtxt.Name = "Staff_IDtxt";
            Staff_IDtxt.Size = new Size(208, 23);
            Staff_IDtxt.TabIndex = 16;
            // 
            // User_IDtxt
            // 
            User_IDtxt.Location = new Point(205, 231);
            User_IDtxt.Name = "User_IDtxt";
            User_IDtxt.Size = new Size(208, 23);
            User_IDtxt.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvReports);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(Report_deletebtn);
            panel2.Controls.Add(Report_addbtn);
            panel2.Controls.Add(Report_updatebtn);
            panel2.Controls.Add(Report_clearbtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 686);
            panel2.TabIndex = 9;
            // 
            // Reports_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 686);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reports_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports_Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private TextBox ReportSearchtxt;
        private Label label3;
        private Label label2;
        private Button Report_deletebtn;
        private Button Report_clearbtn;
        private Button Report_updatebtn;
        private Button Report_addbtn;
        private TextBox Book_Notxt;
        private DataGridView dgvReports;
        private Panel panel4;
        private TextBox IssueReturntxt;
        private TextBox Staff_IDtxt;
        private TextBox User_IDtxt;
        private Panel panel2;
    }
}