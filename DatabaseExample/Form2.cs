using Microsoft.Data.SqlClient;
using System.Data;
namespace DatabaseExample
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        public static Form2 Instance;
        
        public Form2()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = Form1.GetConnection();
        }

        private void btnStdCount_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                MessageBox.Show("No connection established!");
                Hide();
                return;
            }
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new SqlCommand($"Select count(*) from STUDENT Where ClassID='{txtClassId.Text}'", conn);

            int result = (int) command.ExecuteScalar();
            txtStdCount.Text = result + "";
            conn.Close();
        }
    }
}
