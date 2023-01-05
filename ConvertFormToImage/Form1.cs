using System.Windows.Forms;

namespace ConvertFormToImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void PrintForm()
        {
            using (Graphics gfx = this.CreateGraphics())
            {
                using (Bitmap bmp = new Bitmap(this.Width, this.Height, gfx))
                {
                    this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
                    bmp.Save("testing.jpeg");
                    FileInfo file = new FileInfo("testing.jpeg");
                    string test = file.FullName;

                    //File.Open("testing.jpeg", FileMode.Open);
                }
            }
        }

        
    }
}