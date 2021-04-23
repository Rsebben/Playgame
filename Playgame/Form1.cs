using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //allows the use of Thread.sleep()
using System.Media; //allows the use of sound

namespace Playgame
{
    public partial class playGame : Form
    {
        
        public playGame()
        {
            InitializeComponent();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            //start game dissapears
            startGame.Visible = false;

            //countdown from 3 to 1
            countdown.Visible = true;
            countdown.Text = "Game starts in ... 3";
            Refresh();
            Thread.Sleep(1000);
            countdown.Text = "Game starts in ... 2";
            Refresh();
            Thread.Sleep(1000);
            countdown.Text = "Game starts in ... 1";
            Refresh();
            Thread.Sleep(1000);
            countdown.Visible = false;

            //green screen with play and sound
            SoundPlayer alertplayer = new SoundPlayer(Properties.Resources.arcade);
            alertplayer.Play();
                 
            this.BackColor = Color.Green;
            go.Visible = true;














        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
