using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiDocumentExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // declare SecondForm variable formTwo outside event handler
        SecondForm formTwo;

        private void secondFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formTwo == null)
            {
                // open new instance of SecondForm
                formTwo = new SecondForm();

                // need to declare parent of this SecondForm
                // this tells that MainForm is Parent of this formTwo
                formTwo.MdiParent = this;

                // form closing condition
                formTwo.FormClosed += FormTwo_FormClosed;

                formTwo.Show();
            }
            else 
                formTwo.Activate();
        }

        private void FormTwo_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            formTwo = null;
        }

        private void thirdFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this code will open multiple instances of formThree
            // code for form two will only open one instance of formTwo
            ThirdForm formThree = new ThirdForm();
            formThree.MdiParent = this;
            formThree.Show();
        }
    }
}
