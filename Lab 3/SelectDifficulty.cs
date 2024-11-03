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
    public partial class SelectDifficulty : Form
    {
        public SelectDifficulty()
        {
            InitializeComponent();
        }
        int SelectedMode;


        private void UI_OK_btn_Click(object sender, EventArgs e)
        {

            if (UI_Easy_rbtn.Checked)
            {
                SelectedMode = 1;
            }
            else if (UI_Medium_rbtn.Checked)
            {
                SelectedMode = 2;
            }
            else if (UI_Hard_rbtn.Checked)
            {
                SelectedMode = 3;
            }

            else
            {
                MessageBox.Show("Please select game mode. ");
                return; 
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UI_Cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
        
        public int SelectMode
        {
            get
            {
                return SelectedMode;
            }

        }
    }
}
