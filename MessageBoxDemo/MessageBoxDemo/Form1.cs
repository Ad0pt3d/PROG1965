using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void messageBoxBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your message is here.", 
                "Is this what you want?", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
