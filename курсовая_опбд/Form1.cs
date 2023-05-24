namespace курсовая_опбд
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();      
            reg.ShowDialog();
        }
    }
}