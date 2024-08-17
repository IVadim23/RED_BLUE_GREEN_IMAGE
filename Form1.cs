namespace RED_BLUE_GREEN_IMAGE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // image path
            string img = "D:\\image\\colosseum.jpg";
            Bitmap bmp = new Bitmap(img);

            pictureBox1.Image = Image.FromFile(img);
            int width = bmp.Width;  
            int height = bmp.Height;

            Bitmap redBmp = new Bitmap(bmp);
            Bitmap blueBmp = new Bitmap(bmp);
            Bitmap greenBmp = new Bitmap(bmp);

            for (int y = 0; y < height; y++)
            { 
                for (int x = 0; x < width; x++)
                {
                    Color pixsel = bmp.GetPixel(x, y);  

                    int a = pixsel.A;   
                    int r = pixsel.R;
                    int g = pixsel.G;
                    int b = pixsel.B;


                    redBmp.SetPixel(x, y, Color.FromArgb(a, r, 0, 0 ));
                    blueBmp.SetPixel(x,y, Color.FromArgb(a, 0, 0, b ));
                    greenBmp.SetPixel(x,y, Color.FromArgb(a, 0, g, 0 ));

                }
            
            }
            pictureBox2.Image = redBmp;

            pictureBox3.Image = blueBmp;

            pictureBox4.Image = greenBmp;


            redBmp.Save("D:\\image\\Red.jpg");

            blueBmp.Save("D:\\image\\Blue.jpg");

            greenBmp.Save("D:\\image\\Green.jpg");


        }
    }
}
