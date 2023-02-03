using System;

namespace Generic_Collections_ZooSys
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            // isdie >> 0 not , die >>1
            // animal type birds >> 0 , mammals >> 1 , animals >> 2
            zoo.Add(new Birds()   {Name= "Sparrow", animalsType = 0, isDie = 0,Age=8 }) ;
            zoo.Add(new Mammals() {Name="Monotreme",   animalsType = 1, isDie = 0,Age=6 }) ;
            zoo.Add(new Animals() {Name="Lion",     animalsType = 2, isDie = 0,Age=18 }); // age larger than
            zoo.Add(new Animals() {Name="Elephant", animalsType = 2, isDie = 0,Age=9 });
            zoo.Add(new Birds() {Name= "Piegon",   animalsType = 0, isDie = 1,Age=5 }); // Die not added
           
            foreach (Animals item in zoo.birds)
            {
                Console.WriteLine("Birds : " + item.Name + ", Age :" + item.Age);
            }
            Console.WriteLine("********************************************************");
            foreach (Animals item in zoo.mammals)
            {
                Console.WriteLine("Mammals : " + item.Name + ", Age : " + item.Age);
            }
            Console.WriteLine("********************************************************");

            // Calling Delgates to fire events when animal die

            Animals animal = new Animals("Lion1",2,1,5);
            zoo.Add(animal);

            Console.WriteLine("***************************Befor *****************************");
            foreach (Animals item in zoo.animals)
            {
                Console.WriteLine("Animals : " + item.Name + ", Age : " + item.Age);
            }

            animal.Subscriber.Add(zoo);
            animal.checkAnimal += zoo.RemoveAnimal;
            animal.AnimalDie();

            
          
            Console.WriteLine("*************************After*******************************");

            foreach (Animals item in zoo.animals)
            {
                Console.WriteLine("Animals : " + item.Name + ", Age : " + item.Age);
            }

            Console.ReadKey();
        }
    }
}
