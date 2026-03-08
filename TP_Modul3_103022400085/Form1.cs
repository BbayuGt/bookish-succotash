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

        private void refreshOutput()
        {
            output.Text = text;
        }

        private void numButton_Click(object sender, EventArgs e)
        {
            text += (sender as Button).Text;
            refreshOutput();
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            total += Convert.ToInt32(text);
            text = "";
            refreshOutput();
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            total += Convert.ToInt32(text);
            text = Convert.ToString(total);
            total = 0;
            refreshOutput();
        }
    }
}
