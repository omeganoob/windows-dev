namespace DatabaseExample
{
    partial class Form3
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
            this.lbEnter = new System.Windows.Forms.Label();
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.lbClassId = new System.Windows.Forms.Label();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lbClassName = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lvStudent = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.classId = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lbEnter
            // 
            this.lbEnter.AutoSize = true;
            this.lbEnter.Location = new System.Drawing.Point(25, 24);
            this.lbEnter.Name = "lbEnter";
            this.lbEnter.Size = new System.Drawing.Size(99, 20);
            this.lbEnter.TabIndex = 0;
            this.lbEnter.Text = "Enter Class ID";
            // 
            // txtEnter
            // 
            this.txtEnter.Location = new System.Drawing.Point(148, 21);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(125, 27);
            this.txtEnter.TabIndex = 1;
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewDetail.Location = new System.Drawing.Point(25, 74);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(248, 40);
            this.btnViewDetail.TabIndex = 2;
            this.btnViewDetail.Text = "View in Detail";
            this.btnViewDetail.UseVisualStyleBackColor = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // lbClassId
            // 
            this.lbClassId.AutoSize = true;
            this.lbClassId.Location = new System.Drawing.Point(25, 143);
            this.lbClassId.Name = "lbClassId";
            this.lbClassId.Size = new System.Drawing.Size(61, 20);
            this.lbClassId.TabIndex = 3;
            this.lbClassId.Text = "Class ID";
            // 
            // txtClassId
            // 
            this.txtClassId.Location = new System.Drawing.Point(128, 140);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(145, 27);
            this.txtClassId.TabIndex = 4;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(128, 199);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(145, 27);
            this.txtClassName.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(128, 260);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(145, 27);
            this.txtYear.TabIndex = 6;
            // 
            // lbClassName
            // 
            this.lbClassName.AutoSize = true;
            this.lbClassName.Location = new System.Drawing.Point(25, 202);
            this.lbClassName.Name = "lbClassName";
            this.lbClassName.Size = new System.Drawing.Size(86, 20);
            this.lbClassName.TabIndex = 7;
            this.lbClassName.Text = "Class Name";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(25, 263);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(37, 20);
            this.lbYear.TabIndex = 8;
            this.lbYear.Text = "Year";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(369, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "View List of Students";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvStudent
            // 
            this.lvStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.classId});
            this.lvStudent.Location = new System.Drawing.Point(369, 140);
            this.lvStudent.Name = "lvStudent";
            this.lvStudent.Size = new System.Drawing.Size(380, 269);
            this.lvStudent.TabIndex = 10;
            this.lvStudent.UseCompatibleStateImageBehavior = false;
            this.lvStudent.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Student ID";
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // classId
            // 
            this.classId.Text = "Class ID";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvStudent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbClassName);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtClassId);
            this.Controls.Add(this.lbClassId);
            this.Controls.Add(this.btnViewDetail);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.lbEnter);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbEnter;
        private TextBox txtEnter;
        private Button btnViewDetail;
        private Label lbClassId;
        private TextBox txtClassId;
        private TextBox txtClassName;
        private TextBox txtYear;
        private Label lbClassName;
        private Label lbYear;
        private Button button1;
        private ListView lvStudent;
        private ColumnHeader id;
        private ColumnHeader name;
        private ColumnHeader classId;
    }
}