using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* InClass4Form.cs
     * A simple program to demonstrate the use of interfaces and implementation
     * within regards to object oriented programming. The program will consist
     * of a list of animals that have a name and an emoji that corresponds to
     * the type of animal. There will also be a 'Speak' button which will play
     * a sound of the animal based the on current animal selected.
     * 
     * Revision History:
     *      Rafi Miah & Danial Tossel, 2024.07.03: Created
     */

namespace InClass4
{
    public partial class InClass4Form : Form
    {
        public InClass4Form()
        {
            InitializeComponent();

            // Creating Cat and Dog objects for the list box
            animalsLstBox.Items.Add(new Dog("Rex"));
            animalsLstBox.Items.Add(new Cat("Garfield"));
            animalsLstBox.Items.Add(new Dog("Courage"));
            animalsLstBox.Items.Add(new Cat("Whiskers"));
        }

        // Event plays if speak button is pressed
        private void speakBtn_Click(object sender, EventArgs e)
        {
            // Checks if the selected item is of type 'IAnimal' and passes it to the 'selectedAnimal' variable
            if (animalsLstBox.SelectedItem is IAnimal selectedAnimal)
            {
                selectedAnimal.Speak(); // Calls the 'Speak()' method on the selected animal.
            }
        }
    }
}
