namespace Slide6_PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayImage();
        }
        private void DisplayImage()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Width = 398;
            pictureBox.Height = 223;
            pictureBox.Location = new Point(100, 70);
            Bitmap image = new Bitmap("D:\\User Files\\csharp\\repos\\Slide6 PictureBox\\Image\\image.jpg");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = image;
            Controls.Add(pictureBox);
        }
    }
}