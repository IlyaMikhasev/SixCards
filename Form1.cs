using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SixCards
{
    public partial class Form1 : Form
    {
        DistributionCard Cards = new DistributionCard();
        List<PictureBox> _pictureBoxes;
        public Form1()
        {
            
            InitializeComponent();
            _pictureBoxes = new List<PictureBox> (){ pb_card1, pb_card2, pb_card3, pb_card4, pb_card5, pb_card6 };
            toolTip1 = new ToolTip();
        }

        private void pb_title_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pictureBox in _pictureBoxes)
            {
                if (pictureBox.Image == null)
                    Cards.addCard(pictureBox);
                else
                    continue;
            }
        }

        private void pb_card1_Click(object sender, EventArgs e)
        {
            Cards.removeCard((PictureBox)sender);
        }

        private void pb_card2_Click(object sender, EventArgs e)
        {
            Cards.removeCard((PictureBox)sender);
        }

        private void pb_card3_Click(object sender, EventArgs e)
        {
            Cards.removeCard((PictureBox)sender);
        }

        private void pb_card4_Click(object sender, EventArgs e)
        {
            Cards.removeCard((PictureBox)sender);
        }

        private void pb_card5_Click(object sender, EventArgs e)
        {
            Cards.removeCard((PictureBox)sender);
        }

        private void pb_card6_Click(object sender, EventArgs e)
        {
            Cards.removeCard((PictureBox)sender);
        }

        private void b_dist_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pictureBox in _pictureBoxes)
            {
                if (pictureBox.Image == null)
                    Cards.addCard(pictureBox);
                else
                    continue;
            }
        }
    }
}
