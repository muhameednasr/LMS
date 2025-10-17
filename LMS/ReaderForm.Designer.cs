namespace LMS
{
    partial class ReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderForm));
            btnUpdate = new Button();
            txtPhone = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            btnDelete = new Button();
            btnAdd = new Button();
            label1 = new Label();
            dgv = new DataGridView();
            txtAddress = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkOliveGreen;
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(759, 451);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(66, 28);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(760, 260);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(131, 23);
            txtPhone.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(800, 231);
            label5.Name = "label5";
            label5.Size = new Size(51, 25);
            label5.TabIndex = 27;
            label5.Text = "Phone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(760, 204);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(131, 23);
            txtEmail.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(802, 175);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 25;
            label4.Text = "Email";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(760, 148);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(131, 23);
            txtLastName.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(788, 119);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 23;
            label3.Text = "LastName";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(760, 92);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(131, 23);
            txtFirstName.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(790, 63);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 21;
            label2.Text = "FistName";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(825, 451);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(66, 28);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HotTrack;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(759, 411);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 28);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Firebrick;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(911, 46);
            label1.TabIndex = 18;
            label1.Text = "Readers";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ButtonHighlight;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.GridColor = SystemColors.InactiveBorder;
            dgv.Location = new Point(1, 57);
            dgv.Margin = new Padding(3, 2, 3, 2);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(738, 422);
            dgv.TabIndex = 17;
            dgv.CellClick += dgv_CellClick;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(760, 316);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(131, 23);
            txtAddress.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(795, 287);
            label6.Name = "label6";
            label6.Size = new Size(61, 25);
            label6.TabIndex = 34;
            label6.Text = "Address";
            // 
            // ReaderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 489);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(btnUpdate);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(dgv);
            Name = "ReaderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reader";
            Load += Reader_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFirstName;
        private Label label2;
        private Button btnDelete;
        private Button btnAdd;
        private Label label1;
        private DataGridView dgv;
        private TextBox txtAddress;
        private Label label6;
    }
}