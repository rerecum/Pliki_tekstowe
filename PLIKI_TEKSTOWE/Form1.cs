namespace PLIKI_TEKSTOWE
{
    public partial class Sekretariat : Form
    {
        public Sekretariat()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
                ;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            string[] paths = Directory.GetFiles(@"C:\Users\student\Desktop\zadanie", "*.png");
            List<string> images = paths.ToList();
            Random random = new Random();
            pictureBox1.ImageLocation = paths[random.Next(0, images.Count - 1)];
            if (pictureBox1.ImageLocation.Contains("*.png"))
            {
                
            }
            else
            {
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "Qwerty1@34")
                ;
        }
    }
}