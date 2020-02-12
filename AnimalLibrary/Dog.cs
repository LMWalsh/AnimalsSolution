using System;

namespace AnimalLibrary {
    public enum MuzzleType { Long, Short, Collapsed };
    public enum BarkPitchType { Low, Medium, High };

    public class Dog {
        //data (properties)
        public bool LongTail { get; set; }
        public BarkPitchType BarkPitch { get; set; } //high, medium, low
        public MuzzleType Muzzle { get; set; } //long, short, collapsed
        public bool ExtremeSenseOfSmell { get; set; } = false;
        public string Name { get; set; }

        //from here down are functions (methods)
        public virtual string GetTypeOfDog() {
            return "Dog";
        }

        public Dog(string Name) {
            if (Name == null) {
                this.Name = "Doggy";
            } else {
                this.Name = Name;
            }
        }

        public Dog() { //default Constructor
            //encapsulated data and functions = class
        }
    }
}
