namespace TP_Modul3_103022400085
{
    public partial class Form1 : Form
    {
        private string text = "";
        private int total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        // Fungsi ini hanya digunakan untuk refresh output text
        private void refreshOutput()
        {
            output.Text = text;
        }

        // Fungsi ini secara dinamis menambahkan text dari button, jadi butuh satu fungsi saja untuk 10 button (0-10)
        private void numButton_Click(object sender, EventArgs e)
        {
            text += (sender as Button).Text;
            refreshOutput();
        }

        // Fungsi ini untuk menghitung (+), menambahkan apa yang ada pada label ke total.
        private void buttonplus_Click(object sender, EventArgs e)
        {
            total += Convert.ToInt32(text);
            text = "";
            refreshOutput();
        }

        // Untuk menghitung dan menampilkan total
        private void buttonequal_Click(object sender, EventArgs e)
        {
            total += Convert.ToInt32(text);
            text = Convert.ToString(total);
            total = 0;
            refreshOutput();
        }
    }
}
