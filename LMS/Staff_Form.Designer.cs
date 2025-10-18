namespace LMS
{
    partial class Staff_Form
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
            StaffSearchtxt = new TextBox();
            Staff_addbtn = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dgvStaff = new DataGridView();
            panel4 = new Panel();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            Staff_deletebtn = new Button();
            Staff_clearbtn = new Button();
            Staff_updatebtn = new Button();
            StaffloginIdtxt = new TextBox();
            Staffnametxt = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // StaffSearchtxt
            // 
            StaffSearchtxt.Location = new Point(180, 525);
            StaffSearchtxt.Name = "StaffSearchtxt";
            StaffSearchtxt.Size = new Size(208, 23);
            StaffSearchtxt.TabIndex = 8;
            StaffSearchtxt.TextChanged += StaffSearchtxt_TextChanged;
            // 
            // Staff_addbtn
            // 
            Staff_addbtn.BackColor = Color.FromArgb(7, 13, 45);
            Staff_addbtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Staff_addbtn.ForeColor = Color.White;
            Staff_addbtn.Location = new Point(20, 320);
            Staff_addbtn.Name = "Staff_addbtn";
            Staff_addbtn.Size = new Size(169, 37);
            Staff_addbtn.TabIndex = 2;
            Staff_addbtn.Text = "Add";
            Staff_addbtn.UseVisualStyleBackColor = false;
            Staff_addbtn.Click += Staff_addbtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 13, 45);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 69);
            panel1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(964, 22);
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
            label1.Location = new Point(417, 22);
            label1.Name = "label1";
            label1.Size = new Size(105, 22);
            label1.TabIndex = 0;
            label1.Text = "Staff Page";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvStaff);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(997, 681);
            panel2.TabIndex = 5;
            // 
            // dgvStaff
            // 
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvStaff.Location = new Point(34, 165);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.ReadOnly = true;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.Size = new Size(516, 302);
            dgvStaff.TabIndex = 2;
            dgvStaff.CellContentClick += dgvStaff_CellContentClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Controls.Add(StaffSearchtxt);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(Staff_deletebtn);
            panel4.Controls.Add(Staff_clearbtn);
            panel4.Controls.Add(Staff_updatebtn);
            panel4.Controls.Add(Staff_addbtn);
            panel4.Controls.Add(StaffloginIdtxt);
            panel4.Controls.Add(Staffnametxt);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(590, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(407, 681);
            panel4.TabIndex = 1;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(7, 13, 45);
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(53, 166);
            label3.Name = "label3";
            label3.Size = new Size(78, 22);
            label3.TabIndex = 7;
            label3.Text = "LoginId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(7, 13, 45);
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 95);
            label2.Name = "label2";
            label2.Size = new Size(111, 22);
            label2.TabIndex = 1;
            label2.Text = "Staff Name";
            // 
            // Staff_deletebtn
            // 
            Staff_deletebtn.BackColor = Color.FromArgb(7, 13, 45);
            Staff_deletebtn.Font = new Font("Arial Rounded MT Bold", 11.25F);
            Staff_deletebtn.ForeColor = Color.White;
            Staff_deletebtn.Location = new Point(219, 401);
            Staff_deletebtn.Name = "Staff_deletebtn";
            Staff_deletebtn.Size = new Size(169, 37);
            Staff_deletebtn.TabIndex = 5;
            Staff_deletebtn.Text = "Delete";
            Staff_deletebtn.UseVisualStyleBackColor = false;
            Staff_deletebtn.Click += Staff_deletebtn_Click;
            // 
            // Staff_clearbtn
            // 
            Staff_clearbtn.BackColor = Color.FromArgb(7, 13, 45);
            Staff_clearbtn.Font = new Font("Arial Rounded MT Bold", 11.25F);
            Staff_clearbtn.ForeColor = Color.White;
            Staff_clearbtn.Location = new Point(20, 401);
            Staff_clearbtn.Name = "Staff_clearbtn";
            Staff_clearbtn.Size = new Size(169, 37);
            Staff_clearbtn.TabIndex = 4;
            Staff_clearbtn.Text = "Clear";
            Staff_clearbtn.UseVisualStyleBackColor = false;
            Staff_clearbtn.Click += Staff_clearbtn_Click;
            // 
            // Staff_updatebtn
            // 
            Staff_updatebtn.BackColor = Color.FromArgb(7, 13, 45);
            Staff_updatebtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Staff_updatebtn.ForeColor = Color.White;
            Staff_updatebtn.Location = new Point(219, 320);
            Staff_updatebtn.Name = "Staff_updatebtn";
            Staff_updatebtn.Size = new Size(169, 37);
            Staff_updatebtn.TabIndex = 3;
            Staff_updatebtn.Text = "Update";
            Staff_updatebtn.UseVisualStyleBackColor = false;
            Staff_updatebtn.Click += Staff_updatebtn_Click;
            // 
            // StaffloginIdtxt
            // 
            StaffloginIdtxt.Location = new Point(180, 165);
            StaffloginIdtxt.Name = "StaffloginIdtxt";
            StaffloginIdtxt.Size = new Size(208, 23);
            StaffloginIdtxt.TabIndex = 1;
            // 
            // Staffnametxt
            // 
            Staffnametxt.Location = new Point(180, 94);
            Staffnametxt.Name = "Staffnametxt";
            Staffnametxt.Size = new Size(208, 23);
            Staffnametxt.TabIndex = 0;
            // 
            // Staff_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 681);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Staff_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff_Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox StaffSearchtxt;
        private Button Staff_addbtn;
        private Panel panel1;
        private Label label4;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvStaff;
        private Panel panel4;
        private Label label6;
        private Label label3;
        private Label label2;
        private Button Staff_deletebtn;
        private Button Staff_clearbtn;
        private Button Staff_updatebtn;
        private TextBox StaffloginIdtxt;
        private TextBox Staffnametxt;
    }
}