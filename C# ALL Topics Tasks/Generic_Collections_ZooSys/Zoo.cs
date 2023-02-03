using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Generic_Collections_ZooSys
{
    class Zoo
    {
        animalsList animalList = new animalsList();
        List<Birds> _bird = new List<Birds>();
        List<Mammals> _mammals = new List<Mammals>();



        public void Add(Animals _animal)
        {
            animalList.Add(_animal);
        }
        public animalsList animals
        {
            set
            {
                animalList = value;
            }
            get
            {
                return animalList;
            }


        }
        public IReadOnlyCollection<Birds> birds
        {
            get
            {
                foreach (Animals item in animalList)
                {

                    if (item.animalsType == 0)
                        _bird.Add((Birds)item);
                }
                return _bird.AsReadOnly();
            }
        }

        public IReadOnlyCollection<Mammals> mammals
        {
            get
            {
                foreach (Animals item in animalList)
                {
                    if (item.animalsType == 1)
                        _mammals.Add((Mammals)item);
                }
                return _mammals.AsReadOnly();
            }
        }

        public void RemoveAnimal(Animals animal)
        {
            animals.Remove(animal);
        
        }
    }
}
