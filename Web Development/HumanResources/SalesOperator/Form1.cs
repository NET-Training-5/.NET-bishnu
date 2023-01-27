namespace SalesOperator
{
    public partial class Form1 : Form
    {
        int counter;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            label1.Text = $"You clicked me {counter} times";
        }
    }
}