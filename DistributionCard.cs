using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SixCards
{
    internal class DistributionCard
    {
        List<string> Cards = new List<string>{"2c","3c","4c","5c","6c","7c","8c","9c","10c","Jc","Qc","Kc","Ac",
        "2h","3h","4h","5h","6h","7h","8h","9h","10h","Jh","Qh","Kh","Ah",
        "2s","3s","4s","5s","6s","7s","8s","9s","10s","Js","Qs","Ks","As",
        "2d","3d","4d","5d","6d","7d","8d","9d","10d","Jd","Qd","Kd","Ad"};
        public DistributionCard() {
            Random random = new Random();
            for (int i = Cards.Count - 1; i > 0; i--) {
                int r = random.Next(i+1);
                string tmp = Cards[r];
                Cards[r] = Cards[i];
                Cards[i]=tmp;
            }        
        }
        public void removeCard(PictureBox sender) {
            sender.Image = null;

        }
        public int addCard(PictureBox sender) {
            sender.Image = Image.FromFile(@"imgCards\"+Cards[Cards.Count-1]+".png");
            Cards.RemoveAt(Cards.Count - 1);  
            return Cards.Count;
        }

    }
}
