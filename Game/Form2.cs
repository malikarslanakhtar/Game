using System;
using System.Windows.Forms;

namespace Game
{
    public partial class Form2 : Form
    {

        bool moveright, moveleft, moveup, movedown, gameend;
        string direction = "up";
        int life = 100;
        int run = 10;
        int fire = 5;
        int down;
        int CovidPace = 5;

        //List<PictureBox> CovidList = new List<PictureBox>();

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public Form2()
        {
            InitializeComponent();
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            /*  if (life > 1)
              {
                  LifeBar.Value = life;
              }
              else
              {
                  gameend = true;
              }*/
            lblFire.Text = "Fire:" + fire;
            lblDown.Text = "Down:" + down;

            if (moveup == true && Player.Top > 64)
            {
                Player.Top -= run;
            }
            if (movedown == true && Player.Top + Player.Height < this.ClientSize.Height)
            {
                Player.Top += run;
            }

            if (moveleft == true && Player.Left > 0)
            {
                Player.Left -= run;
            }
            if (moveright == true && Player.Left + Player.Width < this.ClientSize.Width)
            {
                Player.Left += run;
            }
        }

        private void KEYDOWN(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                moveright = true;
                direction = "right";
                Player.Image = Properties.Resources.R;
            }
            if (e.KeyCode == Keys.Left)
            {
                moveleft = true;
                direction = "left";
                Player.Image = Properties.Resources.L; ;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveup = true;
                direction = "up";
                Player.Image = Properties.Resources.Front;
            }
            if (e.KeyCode == Keys.Down)
            {
                movedown = true;
                direction = "down";
                Player.Image = Properties.Resources.Back;
            }
        }

        private void KEYUP(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                moveright = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                moveleft = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                movedown = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                //SafeYourself(direction);
            }
        }
    }
}

           /* private void FireAmmo(string direction)
            {
                AMMO FireAmmo = new AMMO();
                FireAmmo.face = direction;
                FireAmmo.AmmoL = Player.Left + (Player.Width / 2);
                FireAmmo.AmmoFront = Player.Top + (Player.Height / 2);
                
            }
        }
    }
}*/
