using isimuzayi1;
namespace Deney_2
{
    public partial class Form1 : Form
    {
        private int Maksimum(int num1, int num2, int num3)
        {
            if (num1 > num2)
            {
                if (num1 < num3)
                {
                    return num3;
                }
                else
                {
                    return num1;
                }
            }
            else
            {
                if (num2 < num3)
                {
                    return num3;
                }
                else
                {
                    return num2;
                }
            }
        }

        private void degistir1(int num1, int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
        }

        private unsafe void degistir2(int* ptr1, int* ptr2)
        {
            int* ptr_yedek = ptr1;
            ptr1 = ptr2;
            ptr2 = ptr_yedek;
        }

        private void degistir3(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        private int sayiUret(int num1, int num2)
        {
            if (num1 > num2)
            {
                num1 = num1 + num2;
                num2 = num1 - num2;
                num1 = num1 - num2;
            }

            Random randm = new Random();
            int sonuc = randm.Next(num1, num2);
            return sonuc;
        }

        private void yaz()
        {
            OrtakText.Text = "";
            for (int i = 0; i < 10; i++)
            {
                OrtakText.Text += "*";
            }
            OrtakText.Text += "\r\n";
        }

        private void yaz(string text)
        {
            for (int i = 0; i < 10; i++)
            {
                OrtakText.Text += text;
            }
            OrtakText.Text += "\r\n";
        }

        private void yaz(string text, int num)
        {
            for (int i = 0; i < num; i++)
            {
                OrtakText.Text += text;
            }
            OrtakText.Text += "\r\n";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private unsafe void button1_Click(object sender, EventArgs e)
        {
            int a = 5;
            int* aPtr = &a;
            OrtakText.Text = ("�lk Durum: " + "\r\n");
            OrtakText.Text += ("a de�i�keninin adresi: " + ((int)&a).ToString("X") + "\r\n");
            OrtakText.Text += ("a de�i�keninin de�eri: " + Convert.ToString(a) + "\r\n");
            OrtakText.Text += ("aPtr i�aret�isinin adresi: " + ((int)&aPtr).ToString("X") + "\r\n");
            OrtakText.Text += ("aPtr i�aret�isinin tuttu�u adres: " + ((int)aPtr).ToString("X") + "\r\n");
            OrtakText.Text += ("aPtr i�aret�isinin de�eri: " + Convert.ToString(*aPtr) + "\r\n" + "\r\n");

            a = 10;

            OrtakText.Text += ("Son Durum: " + "\r\n");
            OrtakText.Text += ("a de�i�keninin adresi: " + ((int)&a).ToString("X") + "\r\n");
            OrtakText.Text += ("a de�i�keninin de�eri: " + Convert.ToString(a) + "\r\n");
            OrtakText.Text += ("aPtr i�aret�isinin adresi: " + ((int)&aPtr).ToString("X") + "\r\n");
            OrtakText.Text += ("aPtr i�aret�isinin tuttu�u adres: " + ((int)aPtr).ToString("X") + "\r\n");
            OrtakText.Text += ("aPtr i�aret�isinin de�eri: " + Convert.ToString(*aPtr) + "\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OrtakText.Text = Convert.ToString(Maksimum(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));
            }
            catch
            {
                MessageBox.Show("L�tfen t�m de�erleri do�ru ve eksiksiz giriniz !");
            }

        }

        private unsafe void button3_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 5;

            OrtakText.Text = "De�i�kenlerin ve adreslerinin ilk durumu: " + "\r\n";
            OrtakText.Text += "a de�i�keni: " + a + "\r\n" + "b de�i�keni: " + b + "\r\n";
            OrtakText.Text += "a de�i�keninin adresi: " + ((int)&a).ToString("X") + "\r\n";
            OrtakText.Text += "b de�i�eninin adresi: " + ((int)&b).ToString("X") + "\r\n" + "\r\n";

            degistir1(a, b);

            OrtakText.Text += "degistir1 fonksiyonundan sonra de�i�kenlerin son durumu: " + "\r\n";
            OrtakText.Text += "a de�i�keni: " + a + "\r\n" + "b de�i�keni: " + b + "\r\n" + "\r\n";

            degistir2(&a, &b);

            OrtakText.Text += "degistir2 fonksiyonundan sonra de�i�kenlerin adreslerinin son durumu: " + "\r\n";
            OrtakText.Text += "a de�i�keni: " + ((int)&a).ToString("X") + "\r\n" + "b de�i�keni: " + ((int)&b).ToString("X") + "\r\n" + "\r\n";


            degistir3(ref a, ref b);

            OrtakText.Text += "degistir3 fonksiyonundan sonra de�i�kenlerin son durumu: " + "\r\n";
            OrtakText.Text += "a de�i�keni: " + a + "\r\n" + "b de�i�keni: " + b + "\r\n";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            try
            {
                sayi = sayiUret(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                OrtakText.Text = textBox1.Text + " - " + textBox2.Text + " aras�ndaki rastgele say�n�z: " + sayi;
            }
            catch
            {
                MessageBox.Show("L�tfen Ge�erli De�erler Giriniz !");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                yaz();
                yaz(textBox1.Text);
                yaz(textBox1.Text, Convert.ToInt32(textBox3.Text));
            }
            catch
            {
                MessageBox.Show("L�tfen de�erleri do�ru giriniz !");
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str1 = Sinif.str;
            string str2 = isimuzayi2.Sinif.str;

            OrtakText.Text = "�sim Uzay� 1'den gelen veri: " + str1 + "\r\n";
            OrtakText.Text += "�sim Uzay� 2'den gelen veri: " + str2 + "\r\n";
        }
    }
}

