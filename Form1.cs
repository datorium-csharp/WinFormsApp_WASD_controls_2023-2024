namespace WinFormsApp_WASD_controls_2023_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hero_Click(object sender, EventArgs e)
        {
            int speed = 30;
            hero.Left += speed;
            hero.Top += speed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show($"You have pressed {e.KeyChar}");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MoveTheHero(e.KeyCode);
            CollisionCheck();
        }

        private void MoveTheHero(Keys keyCode)
        {
            if (keyCode == Keys.A)
            {
                hero.Left -= 10;
            }
            else if (keyCode == Keys.D)
            {
                hero.Left += 10;
            }
            else if (keyCode == Keys.W)
            {
                hero.Top -= 10;
            }
            else if (keyCode == Keys.S)
            {
                hero.Top += 10;
            }
        }

        private void CollisionCheck()
        {
            if (hero.Bounds.IntersectsWith(food.Bounds))
            {
                food.Visible = false;
            }
        }

    }
}