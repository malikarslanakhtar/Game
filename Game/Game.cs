using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        Label lblGameName = new Label();
        Button btnPlay = new Button();
        Button btnQuit = new Button();
        Thread Next;

        public Form1()
        {
            InitializeComponent();
        }
        public void open(object Obj)
        {
            Application.Run(new Form2());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblGameName.Text = "Save Yourself";
            lblGameName.SetBounds(245, 100, 120, 30);
            lblGameName.ForeColor = Color.Black;
            lblGameName.Font = new Font("Arial", 12);
            this.Controls.Add(lblGameName);

            btnPlay.Text = "Play";
            btnPlay.SetBounds(250, 150, 90, 40);
            this.Controls.Add(btnPlay);
            btnPlay.Click += new EventHandler(btnPlay_Click);

            btnQuit.Text = "Quit";
            btnQuit.SetBounds(250, 200, 90, 40);
            this.Controls.Add(btnQuit);
            btnQuit.Click += new EventHandler(btnQuit_Click);

            void btnPlay_Click(Object Sender, EventArgs E)
            {
                this.Close();
                Next = new Thread(open);
                Next.SetApartmentState(ApartmentState.STA);
                Next.Start();
            }
            void btnQuit_Click(Object Sender, EventArgs E)
            {
                DialogResult Quit = MessageBox.Show("Do you want to Quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Quit == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (Quit == DialogResult.No)
                { }

            }
        }
    }
}
