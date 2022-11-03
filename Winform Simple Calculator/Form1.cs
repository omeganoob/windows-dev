namespace Winform_Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            float a, b;
            try
            {
                a = float.Parse(num1.Text);
                b = float.Parse(num2.Text);
                txtRes.Text = $"{a + b}";
            }
            catch (Exception ex)
            {
                txtRes.Text = "#NaN";
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            float a, b;
            try
            {
                a = float.Parse(num1.Text);
                b = float.Parse(num2.Text);
                txtRes.Text = $"{a - b}";
            }
            catch (Exception ex)
            {
                txtRes.Text = "#NaN";
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            float a, b;
            try
            {
                a = float.Parse(num1.Text);
                b = float.Parse(num2.Text);
                txtRes.Text = $"{a * b}";
            }
            catch (Exception ex)
            {
                txtRes.Text = "#NaN";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            float a, b;
            try
            {
                a = float.Parse(num1.Text);
                b = float.Parse(num2.Text);
                txtRes.Text = $"{(float)a / b}";
            }
            catch (Exception ex)
            {
                txtRes.Text = "#NaN";
            }
        }
    }
}