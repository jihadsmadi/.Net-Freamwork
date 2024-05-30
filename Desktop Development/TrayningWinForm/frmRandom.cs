using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace TrayningWinForm
{
   
    public partial class frmRandom : Form
    {
       
        public frmRandom()
        {
            InitializeComponent();
            
        }

        public List<int> list = new List<int> { };
        


        public int getRandomWithExclusion(Random rnd, int start, int end, List <int> q)
        {
            int random = start + rnd.Next(end - start + 1 - q.Count);
            foreach (int ex in q)
            {
                if (random < ex)
                {
                    break;
                }
                random++;
            }
            return random;
        }

        private string gitRandomList()
        {
            Random rnd = new Random();

            for(int i=0;i<20;i++)
            {
                int x = getRandomWithExclusion(rnd, 1, 20, list);
                list.Add(x);
            }

            return list.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
          
            
            

            textBox1.Text = gitRandomList();
        }
    }
}
