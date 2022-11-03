using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DatabaseExample
{
    public partial class Form3 : Form
    {
        public static Form3 Instance;
        SqlConnection conn;
        public Form3()
        {
            InitializeComponent();
            Instance = this;
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                MessageBox.Show("No connection established!");
                Hide();
                return;
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"select * from CLASS Where ClassID='{txtEnter.Text}'";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                txtClassId.Text = reader.GetString(0);
                txtClassName.Text = reader.GetString(1);
                txtYear.Text = reader.GetInt32(2) + "";
            }
            conn.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = Form1.GetConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvStudent.Items.Clear();
            if (conn == null)
            {
                MessageBox.Show("No connection established!");
                Hide();
                return;
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (txtClassId.Text.Equals(""))
            {
                MessageBox.Show("Class ID is empty");
                return;
            }
            SqlCommand command = new SqlCommand($"select * from STUDENT where ClassID='{txtClassId.Text}'",conn);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                var id = reader.GetString(0);
                var name = reader.GetString(1);
                var classId = reader.GetString(2);
                ListViewItem row = new ListViewItem(id);

                row.SubItems.Add(name);
                row.SubItems.Add(classId);
                lvStudent.Items.Add(row);
            }
            foreach(ColumnHeader c in lvStudent.Columns)
            {
                c.Width = -1;
            }
            conn.Close();
        }
    }
}
