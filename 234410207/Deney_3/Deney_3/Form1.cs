using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using Deney_3_;
namespace Deney_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Dortgen D1 = new Dortgen();
            Dortgen D2 = new Dortgen();

            D1.DegerVer(5, 10);
            D2.DegerVer(20, 30);

            OrtakText.Text = "D1 nesnesinin Alan() fonksiyonu: " + Convert.ToString(D1.Alan()) + "\r\n";
            OrtakText.Text += "D2 nesnesinin Alan() fonksiyonu: " + Convert.ToString(D2.Alan()) + "\r\n"; 

            Dortgen P1;
            Dortgen P2;

            P1 = new Dortgen();
            P2 = new Dortgen();

            P1.DegerVer(10, 20);
            P2.DegerVer(15, 30);

            OrtakText.Text = "P1 için Alan() fonksiyonu: " + Convert.ToString(P1.Alan()) + "\r\n";
            OrtakText.Text += "P2 için Alan() fonksiyonu: " + Convert.ToString(P2.Alan()) + "\r\n";

            P1 = null;
            P2 = null; */
            
            Dortgen obj1 = new Dortgen();

            OrtakText.Text = "Parametresiz kurucunun çalýþtýðý nesne: " + Convert.ToString(obj1.Alan()) + "\r\n";

            Dortgen obj2 = new Dortgen(7, 8);

            OrtakText.Text += "Parametreli kurucunun çalýþtýðý nesne: " + Convert.ToString(obj2.Alan()) + "\r\n";

        }
    }
}
