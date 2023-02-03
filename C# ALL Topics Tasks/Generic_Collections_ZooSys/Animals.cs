using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Collections_ZooSys
{
    delegate void CheckAnimalsDie(Animals animal);

    class Animals
    {

        // Animal Type Birds >> 0 , Mammals >> 1 , Animal >> 2
        public string Name { get; set; }
        public int animalsType { get; set; }
        public int isDie { get; set; }
        public int Age { get; set; }

        public Animals(string _name, int _animalType, int _isDie, int _age)
        {
            Name = _name;
            animalsType = _animalType;
            isDie = _isDie;
            Age = _age;
        }

        

        // Refernce from Delgates
        public event  CheckAnimalsDie checkAnimal;
        public List<Zoo> Subscriber { set; get; } = new List<Zoo>();
        
        public void AnimalDie()
        {
            foreach (Zoo item in Subscriber)
            {
                Console.WriteLine("Animal Die");
                checkAnimal.Invoke(this);
            }
           
        }

        public Animals()
        {


        }



    }
}
