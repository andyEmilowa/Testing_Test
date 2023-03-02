using NUnit.Framework;
using System;
using Aqua;

namespace AquariumProject.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void FishConstructorShouldInicializeCorrectly()
        {
            Fish fish = new Fish("Skumriq", 2);
            Assert.AreEqual("Skumriq", fish.Type);
            Assert.AreEqual(2, fish.Price);

        }
        [Test]
        public void AquariumConstructorShouldInicializeCorrectly()
        {
            Aquarium aquarium = new Aquarium("Square", 200);
            Assert.AreEqual("Square", aquarium.Shape);
            Assert.AreEqual(200, aquarium.Capacity);
        }
        [Test]
        public void AddMethodShoudReduceAquariumCapacity()
        {
            Fish fish = new Fish("Skumriq", 2);
            Aquarium aquarium = new Aquarium("Square", 200);
            aquarium.AddFish(fish);
            Assert.AreEqual(199, aquarium.Capacity);
        }
        [Test]
        public void AddMethodShoudAddFish()
        {
            Fish fish = new Fish("Skumriq", 2);
            Aquarium aquarium = new Aquarium("Square", 200);
            aquarium.AddFish(fish);
            Assert.AreEqual(1, aquarium.Fishes.Count);
        }
        [Test]
        public void AddMethodShoudAddExactliOneFish()
        {
            Fish fish = new Fish("Skumriq", 2);
            Aquarium aquarium = new Aquarium("Square", 200);
            aquarium.AddFish(fish);
            Assert.AreEqual(1, aquarium.Fishes.Count);
        }
        [Test]
        public void AddMethodShoudThrowInvalidOperationException()
        {
            Fish fish = new Fish("Skumriq", 2);
            Aquarium aquarium = new Aquarium("Square", 0);
            Assert.Throws<InvalidOperationException>(() => aquarium.AddFish(fish));
        }
        [Test]
        public void AddMethodShoudThrowExactMessageException()
        {
            Fish fish = new Fish("Skumriq", 2);
            Aquarium aquarium = new Aquarium("Square", 0);
            var ex = Assert.Throws<InvalidOperationException>(() => aquarium.AddFish(fish));
            Assert.AreEqual(ex.Message, "Invalid operation");
        }
        [Test]
        public void ReportAddFishShoudPrintExactSuccessfulMessage()
        {
            Fish fish = new Fish("Skumriq", 2);
            Aquarium aquarium = new Aquarium("Square",200);
            aquarium.AddFish(fish);
            Assert.AreEqual($"You successfully remove a fish!", aquarium.ReportAddFish());
        }
        [Test]
        public void EmptyMethodShoudWorkCorrectly()
        {
            Aquarium aquarium = new Aquarium("Square", 200);
            Fish fish = new Fish("Skumriq", 2);
            aquarium.AddFish(fish);
            aquarium.Empty();
            Assert.AreEqual(100, aquarium.Capacity);
            
        }
        [Test]
        public void EmptyMethodShoudThrowEx()
        {
            Fish fish = new Fish("Skumriq", 2);
            Aquarium aquarium = new Aquarium("Square", 200);
             Assert.Throws<InvalidOperationException>(() => aquarium.Empty());
            
        }
        [Test]
        public void EmptyMethodShoudThrowExactEx()
        {
            Fish fish = new Fish("Skumriq", 2);
            Aquarium aquarium = new Aquarium("Square", 200);
            var ex = Assert.Throws<InvalidOperationException>(() => aquarium.Empty());
            Assert.AreEqual(ex.Message, "Aquarium is empty!");
        }
    }

}


   
