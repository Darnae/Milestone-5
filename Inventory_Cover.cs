using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updated_Inventory
{
    public partial class Inventory_Cover : Form
    {
        public Inventory_Cover()
        {
            InitializeComponent();
        }

        private void Form_Button_Click(object sender, EventArgs e)
        {
            Inventory update = new Inventory();

            update.Show();
        }
    }
}
