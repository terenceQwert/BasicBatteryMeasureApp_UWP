using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrapAp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        void doSomeDelay()
        {
            DateTime datetime = DateTime.Now + TimeSpan.FromMilliseconds(100);
            do
            {

            } while (DateTime.Now == datetime);
        }

        private void pBar_MouseMove(object sender, MouseEventArgs e)
        {
            pBar.Step = 1;
            pBar.Maximum = 100;
            pBar.Minimum = 1;
            for (int i = 1; i <= 100; i++)
            {
                doSomeDelay();
                pBar.PerformStep();
            }

        }
    }
}
