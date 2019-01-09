using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class downloadFrm : Form
    {
        public downloadFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dowloadBtn_MouseHover(object sender, EventArgs e)
        {
            Random random = new Random(); 
                dowloadBtn.Top = random.Next(0, MaximumSize.Height-dowloadBtn.Height);
                dowloadBtn.Left = random.Next(0, MaximumSize.Width-dowloadBtn.Width); 
        }
    }
}
