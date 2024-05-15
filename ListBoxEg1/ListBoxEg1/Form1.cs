using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxEg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string item = this.itemNameTxtBox.Text.ToString();

            // good idea to add a validation
            if (item.Length <= 0)
            {
                MessageBox.Show("Please enter item text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lstBoxSkiing.Items.Add(item);
                this.itemNameTxtBox.Clear();
                this.itemNameTxtBox.Focus();
            }
        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            int count = lstBoxSkiing.Items.Count;
            MessageBox.Show(count.ToString());
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            lstBoxSkiing.Items.Remove(lstBoxSkiing.SelectedItem);
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            lstBoxSkiing.Sorted = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            lstBoxSkiing.Items.Clear();
        }
    }
}
