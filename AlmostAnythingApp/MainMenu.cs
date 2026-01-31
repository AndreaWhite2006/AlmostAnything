namespace AlmostAnythingApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calculator calc = new Calculator();
            calc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.Show();
            this.Hide();
        }
    }
}
