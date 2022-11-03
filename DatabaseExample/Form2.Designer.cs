namespace DatabaseExample
{
    partial class Form2
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
            this.lbClassId = new System.Windows.Forms.Label();
            this.lbStdCount = new System.Windows.Forms.Label();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.txtStdCount = new System.Windows.Forms.TextBox();
            this.btnStdCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbClassId
            // 
            this.lbClassId.AutoSize = true;
            this.lbClassId.Location = new System.Drawing.Point(130, 78);
            this.lbClassId.Name = "lbClassId";
            this.lbClassId.Size = new System.Drawing.Size(61, 20);
            this.lbClassId.TabIndex = 0;
            this.lbClassId.Text = "Class ID";
            // 
            // lbStdCount
            // 
            this.lbStdCount.AutoSize = true;
            this.lbStdCount.Location = new System.Drawing.Point(130, 125);
            this.lbStdCount.Name = "lbStdCount";
            this.lbStdCount.Size = new System.Drawing.Size(138, 20);
            this.lbStdCount.TabIndex = 1;
            this.lbStdCount.Text = "Number Of Student";
            // 
            // txtClassId
            // 
            this.txtClassId.Location = new System.Drawing.Point(339, 75);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(231, 27);
            this.txtClassId.TabIndex = 2;
            // 
            // txtStdCount
            // 
            this.txtStdCount.Enabled = false;
            this.txtStdCount.Location = new System.Drawing.Point(339, 122);
            this.txtStdCount.Name = "txtStdCount";
            this.txtStdCount.Size = new System.Drawing.Size(231, 27);
            this.txtStdCount.TabIndex = 3;
            // 
            // btnStdCount
            // 
            this.btnStdCount.Location = new System.Drawing.Point(260, 210);
            this.btnStdCount.Name = "btnStdCount";
            this.btnStdCount.Size = new System.Drawing.Size(223, 29);
            this.btnStdCount.TabIndex = 4;
            this.btnStdCount.Text = "Calculate number of students";
            this.btnStdCount.UseVisualStyleBackColor = true;
            this.btnStdCount.Click += new System.EventHandler(this.btnStdCount_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStdCount);
            this.Controls.Add(this.txtStdCount);
            this.Controls.Add(this.txtClassId);
            this.Controls.Add(this.lbStdCount);
            this.Controls.Add(this.lbClassId);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbClassId;
        private Label lbStdCount;
        private TextBox txtClassId;
        private TextBox txtStdCount;
        private Button btnStdCount;
    }
}