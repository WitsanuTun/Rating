using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rating
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
        public void showimage(int score)
        {
            switch (score)
            {
                case 1:
                    this.pictureBox1.Image = global::Rating.Properties.Resources.ยอดแย่;
                    break;
                case 2:
                    this.pictureBox1.Image = global::Rating.Properties.Resources.แย่;
                    break;
                case 3:
                    this.pictureBox1.Image = global::Rating.Properties.Resources.ดี;
                    break;
                case 4:
                    this.pictureBox1.Image = global::Rating.Properties.Resources.ดีมาก;
                    break;
                case 5:
                    this.pictureBox1.Image = global::Rating.Properties.Resources.ยอดเยี่ยม;
                    break;
            }

        }

        private void RG_CheckedChanged(object sender, EventArgs e)
        {
            showimage(5);
        }

        private void RDM_CheckedChanged(object sender, EventArgs e)
        {
            showimage(4);
        }

        private void RD_CheckedChanged(object sender, EventArgs e)
        {
            showimage(3);
        }

        private void RY_CheckedChanged(object sender, EventArgs e)
        {
            showimage(2);
        }

        private void RYY_CheckedChanged(object sender, EventArgs e)
        {
            showimage(1);
        }
    }
}
