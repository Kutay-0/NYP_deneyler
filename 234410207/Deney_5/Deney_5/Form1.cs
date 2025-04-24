using Cokbicimlilik;
namespace Deney_5
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

            dortgen.DegerVer(5, 10);
            ucgen.DegerVer(10, 20);

            OrtakText.Text = "Dortgen için Static fonksiyon: " + Yazdir.Yaz(dortgen);
            OrtakText.Text += "Ucgen için Static fonksiyon: " + Yazdir.Yaz(ucgen);
        }
    }
}
