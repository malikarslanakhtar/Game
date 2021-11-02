using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Game
{
    class AMMO
    {
        public string face;
        public int AmmoL;
        public int AmmoFront;

        public int speed = 20;
        private PictureBox Ammo = new PictureBox();
        private Timer AmmoTimer = new Timer();


        public void CreateAmmo(Form Paper)
        {
            Ammo.BackColor = Color.Black;
            Ammo.Size = new Size(5, 5);
            Ammo.Tag = "Ammo";
            Ammo.Left = AmmoL;
            Ammo.Top = AmmoFront;
            Ammo.BringToFront();

            Paper.Controls.Add(Ammo);


            AmmoTimer.Interval = speed;
            //AmmoTimer.Tick += new EventHandler(AmmoTimerEvent);
            AmmoTimer.Start();
        }

        private void AmmoTimerEvent(object sender, EventHandler e)
        {
            if (face == "right")
            {
                Ammo.Left += speed;
            }
            if (face == "left")
            {
                Ammo.Left -= speed;
            }
            if (face == "down")
            {
                Ammo.Top += speed;
            }
            if (face == "up")
            {
                Ammo.Top -= speed;
            }

            if (Ammo.Left < 10 || Ammo.Left > 860 || Ammo.Top < 10 || Ammo.Top > 600)
            {
                AmmoTimer.Stop();
                AmmoTimer.Dispose();
                Ammo.Dispose();
            }
        }
    }
}
