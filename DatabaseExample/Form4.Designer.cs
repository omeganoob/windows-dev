namespace DatabaseExample
{
    partial class Form4
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
            this.lbClassList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvStudents = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.classId = new System.Windows.Forms.ColumnHeader();
            this.lsbClasses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbClassList
            // 
            this.lbClassList.AutoSize = true;
            this.lbClassList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbClassList.Location = new System.Drawing.Point(157, 65);
            this.lbClassList.Name = "lbClassList";
            this.lbClassList.Size = new System.Drawing.Size(107, 20);
            this.lbClassList.TabIndex = 0;
            this.lbClassList.Text = "List of Classes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(510, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Students";
            // 
            // lvStudents
            // 
            this.lvStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.classId});
            this.lvStudents.Location = new System.Drawing.Point(435, 143);
            this.lvStudents.Name = "lvStudents";
            this.lvStudents.Size = new System.Drawing.Size(314, 224);
            this.lvStudents.TabIndex = 3;
            this.lvStudents.UseCompatibleStateImageBehavior = false;
            this.lvStudents.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Student ID";
            // 
            // name
            // 
            this.name.Text = "Student Name";
            // 
            // classId
            // 
            this.classId.Text = "Class ID";
            // 
            // lsbClasses
            // 
            this.lsbClasses.FormattingEnabled = true;
            this.lsbClasses.ItemHeight = 20;
            this.lsbClasses.Location = new System.Drawing.Point(58, 143);
            this.lsbClasses.Name = "lsbClasses";
            this.lsbClasses.Size = new System.Drawing.Size(308, 224);
            this.lsbClasses.TabIndex = 4;
            this.lsbClasses.SelectedIndexChanged += new System.EventHandler(this.lsbClasses_SelectedIndexChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbClasses);
            this.Controls.Add(this.lvStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbClassList);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbClassList;
        private Label label1;
        private ListView lvStudents;
        private ColumnHeader id;
        private ColumnHeader name;
        private ColumnHeader classId;
        private ListBox lsbClasses;
    }
}