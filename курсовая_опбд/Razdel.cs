using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая_опбд
{
    public partial class Razdel : Form
    {
        public Razdel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addRazdel addRazdel = new addRazdel();  
            addRazdel.ShowDialog();
        }
    }
}
