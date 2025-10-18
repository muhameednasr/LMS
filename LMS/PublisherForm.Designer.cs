namespace LMS
{
    partial class PublisherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublisherForm));
            btnUpdate = new Button();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            btnDelete = new Button();
            btnAdd = new Button();
            label1 = new Label();
            dgv = new DataGridView();
            txtYear = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkOliveGreen;
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(382, 311);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 28);
            btnUpdate.TabIndex = 48;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(420, 174);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 42;
            label3.Text = "Year Of Production";
            // 
            // txtName
            // 
            txtName.Location = new Point(384, 121);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 23);
            txtName.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sakkal Majalla", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(461, 92);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 40;
            label2.Text = "Name";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(486, 311);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 28);
            btnDelete.TabIndex = 39;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HotTrack;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(382, 271);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(205, 28);
            btnAdd.TabIndex = 38;
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
            label1.Location = new Point(2, 0);
            label1.Name = "label1";
            label1.Size = new Size(586, 59);
            label1.TabIndex = 37;
            label1.Text = "Readers";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ButtonHighlight;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.GridColor = SystemColors.InactiveBorder;
            dgv.Location = new Point(2, 61);
            dgv.Margin = new Padding(3, 2, 3, 2);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(374, 298);
            dgv.TabIndex = 36;
            dgv.CellClick += dgv_CellClick;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(385, 218);
            txtYear.Margin = new Padding(3, 2, 3, 2);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(203, 23);
            txtYear.TabIndex = 49;
            // 
            // PublisherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 363);
            Controls.Add(txtYear);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(dgv);
            Name = "PublisherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PublisherForm";
            Load += PublisherForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Button btnDelete;
        private Button btnAdd;
        private Label label1;
        private DataGridView dgv;
        private TextBox txtYear;
    }
}