using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Animals.cs
     * Contains the 'IAnimal' interface, 'AnimalBase' class which inherits 'IAnimal',
     * 'Dog' and 'Cat' class which inherits the 'AnimalBase' class. Creates functionality
     * so the speak method will play a sound and give each animal object a name with the corresponding emoji.
     * 
     * Revision History:
     *      Rafi Miah & Danial Tossel, 2024.07.03: Created
     */

namespace InClass4
{
    // Interface for the animal holding a getter and setter for the name, and a 'void Speak()' method.
    public interface IAnimal
    {
        string Name { get; set; }
        void Speak();
    }

    // This class is abstract so it can be fully implemented elsewhere.
    // The base class for any animal, that inherits the interface, also creates
    // a getter and setter for the name and a base constructor to initialize the name.
    // Overrides 'ToString()' to suit our needs of implementing the name and emoji.
    public abstract class AnimalBase : IAnimal
    {
        public string Name { get; set; }

        public AnimalBase(string name)
        {
            Name = name;
        }

        // This method is abstract so it can be fully implemented elsewhere.
        public abstract void Speak();

        public override string ToString()
        {
            return $"{Name} {GetEmoji()}";
        }

        // This method is abstract so it can be fully implemented elsewhere.
        public abstract string GetEmoji();
    }


    // Dog class that inherits the 'AnimalBase' class and overrides the 'Speak()' method with the
    // corresponding wav file and overrides the 'GetEmoji()' method with the right emoji.
    public class Dog : AnimalBase
    {
        // ': base(name)' - This colon and base keyword calls the base constructor from the 'AnimalBase' class
        // passing the name parameter that it gets
        public Dog(string name) : base(name) { }

        // Overrides the 'Speak()' method so we can add the sound for each animal.
        public override void Speak()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Sounds\dog_bark.wav"); // Creates a sound player object that will play the file that is passed.
            player.Play();
        }

        // Overrides the 'GetEmoji()' method so we can get the emoji for each animal.
        public override string GetEmoji()
        {
            return "🐕";
        }
    }

    // Cat class that inherits the 'AnimalBase' class and overrides the 'Speak()' method with the
    // corresponding wav file and overrides the 'GetEmoji()' method with the right emoji.
    public class Cat : AnimalBase
    {
        // ': base(name)' - This colon and base keyword calls the base constructor from the 'AnimalBase' class
        // passing the name parameter that it gets
        public Cat(string name) : base(name) { }

        // Overrides the 'Speak()' method so we can add the sound for each animal.
        public override void Speak()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Sounds\cat_meow.wav"); // Creates a sound player object that will play the file that is passed.
            player.Play(); // Plays the sound that was passed
        }

        // Overrides the 'GetEmoji()' method so we can get the emoji for each animal.
        public override string GetEmoji()
        {
            return "🐈";
        }
    }
}
