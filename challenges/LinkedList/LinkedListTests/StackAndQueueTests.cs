using System;
using Xunit;
using System.Text;
using LinkedLists;

namespace LinkedListTests
{
    public class StackAndQueueTests
    {
        [Fact]
        public void Push_To_Stack()
        {
            Stack<string> test = new Stack<string>();
            test.Push("15");
            Assert.Equal("15", test.top.Value);

        }

        [Fact]
        public void With_Stacks_Enqueue()
        {
            PseudoQueue<int> queue = new PseudoQueue<int>();
            queue.enqueue(4);
            Assert.Equal(5, queue.enqueue(5));
        }

        [Fact]
        public void With_Stacks_Enqueue_Fail()
        {
            PseudoQueue<int> queue = new PseudoQueue<int>();
            Assert.NotEqual(7, queue.enqueue(5));
        }

        [Fact]
        public void With_Stacks_Dequeue()
        {
            PseudoQueue<int> queue = new PseudoQueue<int>();
            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);
            queue.enqueue(4);

            Assert.Equal(1, queue.dequeue().Value);
        }

        [Fact]
        public void With_Stacks_Dequeue_Fail()
        {
            PseudoQueue<int> queue = new PseudoQueue<int>();
            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);
            queue.enqueue(4);

            Assert.NotEqual(5, queue.dequeue().Value);
        }

        [Fact]
        public void With_Stacks_Dequeue_Empty()
        {
            PseudoQueue<int> queue = new PseudoQueue<int>();
            Assert.Null(queue.dequeue());
        }

        [Fact]
        public void Shelter_Enqueue_Expected()
        {
            FIFOAnimalShelter shelter = new FIFOAnimalShelter();
            Animal cat = new Cat();
            Assert.Equal(cat,shelter.Enqueue(cat));
        }

        [Fact]
        public void Shelter_Enqueue_Fail()
        {
            FIFOAnimalShelter shelter = new FIFOAnimalShelter();
            Assert.Null(shelter.shelterAnimals.front);
        }

        [Fact]
        public void Shelter_Dequeue_Expected()
        {
            FIFOAnimalShelter shelter = new FIFOAnimalShelter();
            Animal cat = new Cat();
            Animal dog = new Dog();
            shelter.Enqueue(cat);
            shelter.Enqueue(dog);
            Assert.Equal(cat, shelter.Dequeue("cat"));

        }

        [Fact]
        public void Shelter_Dequeue_Fail()
        {
            FIFOAnimalShelter shelter = new FIFOAnimalShelter();
            Assert.Null(shelter.Dequeue("dog"));
        }

        [Fact]
        public void Shelter_Dequeue_Incorrect_Value()
        {
            FIFOAnimalShelter shelter = new FIFOAnimalShelter();
            Animal cat = new Cat();
            Animal dog = new Dog();
            shelter.Enqueue(cat);
            shelter.Enqueue(dog);
            Assert.Null(shelter.Dequeue("fish"));
        }
    }
}
