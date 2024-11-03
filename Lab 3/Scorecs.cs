using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public delegate void delVoidVoid();

    public partial class Scorecs : Form
    {
        public delVoidVoid _dFormClosing = null;

        int score;
        string score1; 
        public Scorecs()
        {
            InitializeComponent();
        }

        private void UI_ModelessDialogClosing(object sender, FormClosingEventArgs e)
        {
            //If the form is being closed by the user- we can intercept the action
            //and hide the form instead of destroying it
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //We first verify that the delegate is not null before invoking it
                if (_dFormClosing != null)
                    _dFormClosing();

                //Cancel the normal closing event
                e.Cancel = true;


                Hide(); //Hide the form instead of destroying it.
            }
        }

        private void UI_Score_lbl_Click(object sender, EventArgs e)
        {

        }

        private void UI_ScoreUpdate(object sender, EventArgs e)
        {

        }

        public int GameScore
        {
            set
            {
                score = value;
                score1 = score.ToString();
                UI_Score_lbl.Text = score1; 
            }
        }
    }
}
