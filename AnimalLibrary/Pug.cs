using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class Pug : Dog {

        public bool IsSmall { get; set; }

        //constructor to pass in name
        public Pug(string Name) : base(Name) {
            IsSmall = true;
            Muzzle = MuzzleType.Collapsed;
        }
        //default constructor
        public Pug() : this("Spot") {
            
        }
        public override string GetTypeOfDog() {
            return "Pug";
        }
    }
}
