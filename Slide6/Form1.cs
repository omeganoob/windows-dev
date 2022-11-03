using System.Text;
namespace Slide6
{
    public partial class frmEmployeeDetails : Form
    {
        public frmEmployeeDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var eID = txtID.Text;
            var eName = txtName.Text;
            var phone = txtPhone.Text;
            var gender = rdMale.Checked ? "Male" : "Female";
            var degree = cboDegree.Text;
            StringBuilder builder = new StringBuilder();
            builder.Append($"Employee ID: {eID}\n");
            builder.Append($"Employee Name: {eName}\n");
            builder.Append($"Phone: {phone}\n");
            builder.Append($"Gender: {gender}\n");
            builder.Append($"Degree: {degree}\n");
            MessageBox.Show(builder.ToString(), "Employee details");

                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}