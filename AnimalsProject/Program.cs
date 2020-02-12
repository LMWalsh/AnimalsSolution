using System;
using System.Collections.Generic;
using AnimalLibrary;

namespace AnimalsProject {
    class Program {
        static void Main(string[] args) {

            var boxer1 = new Boxer();
            var pug1 = new Pug("ThePug");
            var pug2 = new Pug();


            var gs1 = new GermanSheperd("Killer");
            
           
            var germanSheperd = new GermanSheperd { 
                LongTail = true,
                BarkPitch = BarkPitchType.Low,
                Muzzle = MuzzleType.Long,
                ExtremeSenseOfSmell = true,
                BigDog = true,
                Name = "Fred"
            };
            var pug = new Dog {
                LongTail = false,
                BarkPitch = BarkPitchType.High,
                Muzzle = MuzzleType.Collapsed,
                ExtremeSenseOfSmell = false,
                Name = "Ralph"
                       
                };
            //an array; var plural for arrays and singular for step through in foreach
            var dogs = new List<Dog>();
            dogs.Add(pug);
            dogs.Add(germanSheperd);
            dogs.Add(gs1);
            dogs.Add(pug2);
            dogs.Add(pug1);
            dogs.Add(boxer1);

            foreach(var dog in dogs) {
                Console.WriteLine(dog.GetTypeOfDog());
                //the above, from last comment, is an example of Polymorphism
            }

            
            
        }
    }
}
