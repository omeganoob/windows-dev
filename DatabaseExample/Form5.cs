using Microsoft.Data.SqlClient;
using System.Data;

namespace DatabaseExample
{
    public partial class Form5 : Form
    {
        public static Form5 Instance;
        SqlConnection conn;
        int result = -1;
        public Form5()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            conn = Form1.GetConnection();
            InitListViewStudent();
        }

        private void InitListViewStudent()
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

            SqlCommand command = new SqlCommand("select * from STUDENT", conn);

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                var id = reader.GetString(0);
                var name = reader.GetString(1);
                var classId = reader.GetString(2);

                ListViewItem row = lvStudent.Items.Add(id);
                row.SubItems.Add(name);
                row.SubItems.Add(classId);
            }

            conn.Close();

            foreach (ColumnHeader c in lvStudent.Columns)
            {
                c.Width = -1;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
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
            command.Connection = conn;
            command.CommandText = "insert into STUDENT(StudentID,Name,ClassID) value(@StudentID, @Name, @ClassID)";
            SqlParameter id = new SqlParameter("@StudentID", txtStudentId.Text);
            command.Parameters.Add(id);
            SqlParameter name = new SqlParameter("@Name", txtName.Text);
            command.Parameters.Add(name);
            SqlParameter classId = new SqlParameter("@ClassID", txtClassId.Text);
            command.Parameters.Add(classId);

            try
            {
                // using .ExecuteNonQuery() for insert, update or delete
                result = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nInsert record failed.");
            }

            if(result > 0)
            {
                InitListViewStudent();
            }
        }

        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvStudent.SelectedItems.Count == 1)
            {
                txtStudentId.Text = lvStudent.SelectedItems[0].SubItems[0].Text;
                txtName.Text = lvStudent.SelectedItems[0].SubItems[1].Text;
                txtClassId.Text = lvStudent.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

            SqlCommand command = new SqlCommand($"update STUDENT set Name='{txtName.Text}'," +
                $"ClassID = '{txtClassId.Text}'" +
                $" where StudentID='{txtStudentId.Text}'", conn);

            try
            {
                result = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nRecord update failed.");
            }

            if(result > 0)
            {
                InitListViewStudent();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
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

            SqlCommand command = new SqlCommand($"delete from STUDENT where StudentID='{txtStudentId.Text}'", conn);

            try
            {
                result = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nRemove failed.");
            }

            if(result > 0)
            {
                InitListViewStudent();
                txtStudentId.Text = "";
                txtName.Text = "";
                txtClassId.Text = "";
            }
        }
    }
}
