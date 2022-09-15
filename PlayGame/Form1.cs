using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PlayGame
{
    public partial class normalForm : System.Windows.Forms.Form
    {
        public normalForm()
        {
            InitializeComponent();
            scoreButton.Hide(); 
            
        }

        
        private void playButton_Click(object sender, EventArgs e)
        {
            playButton.Hide();
            greenColor.Hide(); 

            SoundPlayer goPlayer = new SoundPlayer(Properties.Resources.readyGo);
            goPlayer.Play();

            Thread.Sleep(900);
            
            startingLabel.Show();

            Refresh();

            Thread.Sleep(1000);
            startingLabel.Text = "Game is starting in: 2";
            Refresh();

            Thread.Sleep(1000);
            startingLabel.Text = "Game is starting in: 1";
            Refresh();

            Thread.Sleep(1000);

            startingLabel.Text = "";
            greenColor.Show();
            scoreButton.Show();
            exitButton.Show();
            Refresh();

           
            
            Refresh();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            SoundPlayer rickPlayer = new SoundPlayer(Properties.Resources.rick);

            rickPlayer.Play();

            Thread.Sleep(2000);
            System.Windows.Forms.Application.ExitThread();
        }
        int score = 0;
        private void scoreButton_Click(object sender, EventArgs e)
        { 
            score = score + 1;

            scoreButton.Text = "Score: " + score;
        }
    }
}
