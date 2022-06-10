namespace ProjetoPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
                timer1.Enabled = true;
                progressBar1.Increment(2);
                if (progressBar1.Value == 100)
                {
                    timer1.Enabled = false;
                    Form2 form = new Form2();
                    form.Show();
                    this.Hide();

                }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}