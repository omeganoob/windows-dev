using Microsoft.Data.SqlClient;
using System.Data;

namespace DatabaseExample
{
    public partial class Form1 : Form
    {
        static SqlConnection conn;
        string STR_CONN = "database=STUDENT_MANAGEMENT;Server=LAPTOP-7O0MSIJ0\\SQLEXPRESS;User id=sa; password=chung123;TrustServerCertificate=True";
        public static Form1 Instance;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(STR_CONN);
                conn.Open();
                MessageBox.Show("Successful connection");
                lbStatus.ForeColor = Color.Lime;
            } catch(Exception ex)
            {
                MessageBox.Show("Failed to connect to the server \n" + ex.Message);
            }
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if(conn != null && conn.State==ConnectionState.Open)
            {
                conn.Close();
                lbStatus.ForeColor = Color.Red;
                MessageBox.Show("Successful Disconnection!");
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
        public static SqlConnection GetConnection()
        {
            return conn;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}