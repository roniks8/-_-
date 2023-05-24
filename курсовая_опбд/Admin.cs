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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(); 
            menu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sostav sostav = new Sostav();
            sostav.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ingredients ingredients = new Ingredients();    
            ingredients.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Razdel razdel = new Razdel();
            razdel.ShowDialog();
        }
    }
}
