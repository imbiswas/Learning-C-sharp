using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarket
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int startpoint = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBarSplash.Value = startpoint;
            if (progressBarSplash.Value == 100)
            {
                progressBarSplash.Value = 0;
                timer1.Stop();
                Form1 log = new Form1();
                this.Hide();
                log.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
