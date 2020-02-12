using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class Boxer : Dog {

        public Boxer(string Name) : base(Name) {
            //calls default from Dog
        }

        public Boxer() {

        }
        public override string GetTypeOfDog() {
            return "Boxer";
        }
    }
}
