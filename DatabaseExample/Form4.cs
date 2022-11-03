using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace DatabaseExample
{
    public partial class Form4 : Form
    {
        public static Form4 Instance;
        SqlConnection conn;
        public Form4()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn = Form1.GetConnection();

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

            SqlCommand command = new SqlCommand("select * from CLASS", conn);
            lsbClasses.ClearSelected();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                var id = reader.GetString(0);
                var name = reader.GetString(1);
                var year = reader.GetInt32(2);
                string line = id + "-" + name +"-" + year;
                lsbClasses.Items.Add(line);
            }
            conn.Close();
        }

        private void lsbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvStudents.Items.Clear();
            if (lsbClasses.SelectedIndex == -1) return;

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

            var line = lsbClasses.SelectedItem.ToString();
            var array = line.Split("-");
            var classId = array[0];
            //var classId = Regex.Match(line, @"^([^-]*)-");

            SqlCommand command = new SqlCommand($"select * from STUDENT where ClassID='{classId}'", conn);

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                var id = reader.GetString(0);
                var name = reader.GetString(1);
                var classid = reader.GetString(2);
                ListViewItem row = lvStudents.Items.Add(id);
                row.SubItems.Add(name);
                row.SubItems.Add(classid);
            }
            foreach(ColumnHeader c in lvStudents.Columns)
            {
                c.Width = -1;
            }
            conn.Close();
        }
    }
}
