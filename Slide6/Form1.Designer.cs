namespace Slide6
{
    partial class frmEmployeeDetails
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.cboDegree = new System.Windows.Forms.ComboBox();
            this.lbDegree = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(267, 21);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(259, 40);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Employee Details";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(209, 109);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(94, 20);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "Employee ID";
            this.lbID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(347, 106);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(226, 27);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(209, 151);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(119, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Employee Name";
            this.lbName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(347, 148);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 27);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(209, 198);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(50, 20);
            this.lbPhone.TabIndex = 1;
            this.lbPhone.Text = "Phone";
            this.lbPhone.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(209, 250);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(57, 20);
            this.lbGender.TabIndex = 1;
            this.lbGender.Text = "Gender";
            this.lbGender.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupGender
            // 
            this.groupGender.Controls.Add(this.rdFemale);
            this.groupGender.Controls.Add(this.rdMale);
            this.groupGender.Location = new System.Drawing.Point(347, 228);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(226, 59);
            this.groupGender.TabIndex = 3;
            this.groupGender.TabStop = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(347, 195);
            this.txtPhone.Mask = "000-0000000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(226, 27);
            this.txtPhone.TabIndex = 4;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Location = new System.Drawing.Point(22, 26);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(63, 24);
            this.rdMale.TabIndex = 0;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(127, 26);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(78, 24);
            this.rdFemale.TabIndex = 0;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // cboDegree
            // 
            this.cboDegree.FormattingEnabled = true;
            this.cboDegree.Items.AddRange(new object[] {
            "Ph. D.",
            "Master",
            "Engineer",
            "Bachelor",
            "Technician"});
            this.cboDegree.Location = new System.Drawing.Point(347, 308);
            this.cboDegree.Name = "cboDegree";
            this.cboDegree.Size = new System.Drawing.Size(226, 28);
            this.cboDegree.TabIndex = 1;
            this.cboDegree.Text = "---Select Degree---";
            // 
            // lbDegree
            // 
            this.lbDegree.AutoSize = true;
            this.lbDegree.Location = new System.Drawing.Point(209, 311);
            this.lbDegree.Name = "lbDegree";
            this.lbDegree.Size = new System.Drawing.Size(58, 20);
            this.lbDegree.TabIndex = 1;
            this.lbDegree.Text = "Degree";
            this.lbDegree.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(279, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(446, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEmployeeDetails
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboDegree);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.groupGender);
            this.Controls.Add(this.lbDegree);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmEmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitle;
        private Label lbID;
        private TextBox txtID;
        private Label lbName;
        private TextBox txtName;
        private Label lbPhone;
        private Label lbGender;
        private GroupBox groupGender;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private MaskedTextBox txtPhone;
        private ComboBox cboDegree;
        private Label lbDegree;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnSave;
        private Button btnCancel;
    }
}