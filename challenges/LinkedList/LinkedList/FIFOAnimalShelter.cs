using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class FIFOAnimalShelter
    {
        public Queue<Animal> shelterAnimals = new Queue<Animal>();

        /// <summary>
        /// adds the animal to the end of the queue
        /// </summary>
        /// <param name="animal">the animal to be placed in the shelter</param>
        public Animal Enqueue(Animal animal)
        {
            shelterAnimals.enqueue(animal);
            return shelterAnimals.front.Value;
        }

        /// <summary>
        ///searches through the queue for the first instance of the preferred animal
        /// </summary>
        /// <param name="pref">string matching the species value of the animal</param>
        /// <returns>First animal object in the queue that corresponds to the preffered value</returns>
        public Animal Dequeue(string pref)
        {
            //instantiate queue to temporarily hold values not matching pref
            Queue<Animal> temp = new Queue<Animal>();
            Node<Animal> current = shelterAnimals.front;
            //check for empty shelter
            if(current == null)
            {
                return null;
            }
            //iterate through queue until the first instance of pref is found
            while(current.Value.Species != pref)
            {
                temp.enqueue(shelterAnimals.dequeue().Value);
                current = current.Next;
                if(current == null)
                {
                    break;
                }
            }
            //save that object in that node
            Animal finalAnim = shelterAnimals.dequeue().Value;
            current = shelterAnimals.front;
            //iterate remainder of the queue
            while(current != null)
            {
                temp.enqueue(shelterAnimals.dequeue().Value);
                current = current.Next;
            }
            Node<Animal> current2 = temp.front;
            while(current2 != null)
            {
                shelterAnimals.enqueue(temp.dequeue().Value);
                current2 = current2.Next;
            }
            return finalAnim;
        }
    }
}
