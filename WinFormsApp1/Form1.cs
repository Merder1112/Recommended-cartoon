using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            hide();
            buttonblackaction.Hide();
            buttonblackdrama.Hide();

        }
        Drama drama = new Drama();
        Action action = new Action();
        CsvWriter csv = new CsvWriter();
        int[] count = new int[6];
        public void showaction()
        {
            ButtonREAD1.Show();
            ButtonREAD2.Show();
            ButtonREAD3.Show();
        }
        public void showdrama()
        {
            ButtonREAD4.Show();
            ButtonREAD5.Show();
            ButtonREAD6.Show();
        }
        public void hide()
        {
            ButtonREAD1.Hide();
            ButtonREAD2.Hide();
            ButtonREAD3.Hide();
            ButtonREAD4.Hide();
            ButtonREAD5.Hide();
            ButtonREAD6.Hide();
        }





        private void button1_Click(object sender, EventArgs e)
        {

            if (ActionBTN.Visible)
            {
                // แสดงปุ่ม Button ที่ซ่อนไว้
                hide();
                showaction();
                buttonblackdrama.Hide();
                Background.Image = Properties.Resources.แอคชั่นการ์ตูน;
                buttonblackaction.Hide();
                buttonblackdrama.Hide();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (DramaBTN.Visible)
            {
                // แสดงปุ่ม Button ที่ซ่อนไว้
                hide();
                showdrama();
                buttonblackaction.Hide();
                Background.Image = Properties.Resources.ดราม่าการ์ตูน;
                buttonblackaction.Hide();
                buttonblackdrama.Hide();



            }
        }

        private void ButtonREAD1_Click(object sender, EventArgs e)
        {


            Background.Image = action.pic1;
            count[0]++;
            hide();
            buttonblackaction.Show();


        }

        private void ButtonREAD2_Click(object sender, EventArgs e)
        {
            Background.Image = action.pic2;
            count[1]++;
            hide();
            buttonblackaction.Show();

        }

        private void ButtonREAD3_Click(object sender, EventArgs e)
        {
            Background.Image = action.pic3;
            count[2]++;
            hide();
            buttonblackaction.Show();
        }
        private void ButtonREAD6_Click(object sender, EventArgs e)
        {
            Background.Image = drama.pic6;
            count[3]++;
            hide();
            buttonblackdrama.Show();
        }

        private void ButtonREAD5_Click(object sender, EventArgs e)
        {
            Background.Image = drama.pic5;
            count[4]++;
            hide();

            buttonblackdrama.Show();
        }

        private void ButtonREAD4_Click(object sender, EventArgs e)
        {
            Background.Image = drama.pic4;
            count[5]++;
            hide();

            buttonblackdrama.Show();
        }

        private void buttonblack_Click(object sender, EventArgs e)
        {
            showaction();
            Background.Image = Properties.Resources.แอคชั่นการ์ตูน;
            buttonblackaction.Hide();
            buttonblackdrama.Hide();
        }

        private void buttonblackdrama_Click(object sender, EventArgs e)
        {
            showdrama();
            Background.Image = Properties.Resources.ดราม่าการ์ตูน;
            buttonblackaction.Hide();
            buttonblackdrama.Hide();

        }

        private void CSV_Click(object sender, EventArgs e)
        {
            bool canWrite = csv.WriteToCsv(count);
            if (canWrite)
            {
                MessageBox.Show("เขียนไฟล์สำเร็จ");
            }
            else
            {
                MessageBox.Show("เขียนไฟล์ไม่สำเร็จ");
            }
        }

        private void ReadCSV_Click(object sender, EventArgs e)
        {
            bool canRead = csv.ReadFile();
            if (canRead)
            {
                MessageBox.Show("อ่านไฟล์สำเร็จ");
            }
            else
            {
                MessageBox.Show("อ่านไฟล์ไม่สำเร็จ");
            }
        }
    }
}
