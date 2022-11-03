namespace DatabaseExample
{
    partial class Form5
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
            this.lvStudent = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.classId = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbClassId = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvStudent
            // 
            this.lvStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.classId});
            this.lvStudent.Location = new System.Drawing.Point(12, 12);
            this.lvStudent.Name = "lvStudent";
            this.lvStudent.Size = new System.Drawing.Size(457, 426);
            this.lvStudent.TabIndex = 0;
            this.lvStudent.UseCompatibleStateImageBehavior = false;
            this.lvStudent.View = System.Windows.Forms.View.Details;
            this.lvStudent.SelectedIndexChanged += new System.EventHandler(this.lvStudent_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "Student ID";
            // 
            // name
            // 
            this.name.Text = "Student name";
            // 
            // classId
            // 
            this.classId.Text = "Class ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbClassId);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.txtClassId);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtStudentId);
            this.groupBox1.Controls.Add(this.lbId);
            this.groupBox1.Location = new System.Drawing.Point(475, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // lbClassId
            // 
            this.lbClassId.AutoSize = true;
            this.lbClassId.Location = new System.Drawing.Point(6, 102);
            this.lbClassId.Name = "lbClassId";
            this.lbClassId.Size = new System.Drawing.Size(61, 20);
            this.lbClassId.TabIndex = 3;
            this.lbClassId.Text = "Class ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(6, 69);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(76, 20);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Full Name";
            // 
            // txtClassId
            // 
            this.txtClassId.Location = new System.Drawing.Point(110, 99);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(197, 27);
            this.txtClassId.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 27);
            this.txtName.TabIndex = 1;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(110, 34);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(197, 27);
            this.txtStudentId.TabIndex = 1;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(6, 37);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(79, 20);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Student ID";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(481, 180);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 29);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(581, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(681, 180);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvStudent);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvStudent;
        private GroupBox groupBox1;
        private Label lbClassId;
        private Label lbName;
        private TextBox txtClassId;
        private TextBox txtName;
        private TextBox txtStudentId;
        private Label lbId;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnRemove;
        private ColumnHeader id;
        private ColumnHeader name;
        private ColumnHeader classId;
    }
}