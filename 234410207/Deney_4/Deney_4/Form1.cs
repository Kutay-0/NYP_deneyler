using Kalitim;
namespace Deney_4
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
            Dortgen dortgen = new Dortgen();
            Ucgen ucgen = new Ucgen();

            dortgen.DegerVer(3, 5);
            ucgen.DegerVer(10, 5);

            OrtakText.Text = "Dortgenin alaný: " + Convert.ToString(dortgen.Alan()) + "\r\n";
            OrtakText.Text += "Ucgenin alaný: " + Convert.ToString(ucgen.Alan()) + "\r\n" + "\r\n";

            OrtakText.Text += "Dörtgenin Yaz fonksiyonu: " + dortgen.Yaz()
        }
    }
}
