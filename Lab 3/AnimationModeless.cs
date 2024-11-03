using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public delegate int delAnimation(int speed);
    public delegate void delVoid();
    public partial class AnimationModeless : Form
    {
        public delVoid _dFormClosing = null;
        public delAnimation _AnimationSpeed = null;
        public AnimationModeless()
        {
            InitializeComponent();
        }

        private void UI_ClosingModeless(object sender, FormClosingEventArgs e)
        {
            //if the mdls dlg is closing,
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (null != _dFormClosing)
                {
                    _dFormClosing();
                }

                e.Cancel = true;
                Hide();
            }
        }

        private void UI_TrackBarScroll(object sender, EventArgs e)
        {
            _AnimationSpeed.Invoke(UI_Animation_TrkBar.Value);

        }


    }
}
