namespace fukuv0525
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kato masahiro");
            label1.Visible = false;
            button1.Left = button1.Left + 15;
            button2.Left = button2.Left + 15;
            button3.Left = button3.Left + 15;
            button4.Left = button4.Left + 15;
        }
    }
}