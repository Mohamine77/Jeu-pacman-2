using System;
using System.Windows.Forms;

namespace Jeu_pacman
{
    public partial class Main : Form
    {
        public static Main menu { get; private set; }

        public Main()
        {
            InitializeComponent();
            menu = this;
            lblMeilleurepartie.Parent = fondmenu;
        }
        public void ShowMenu()
        {
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NouvellePartie secondWindow = new NouvellePartie();
            secondWindow.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Param�tres secondWindow = new Param�tres();
            secondWindow.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jeu secondWindow = new Jeu();
            secondWindow.Show();
            this.Hide();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
