using System;
using NUnit.Framework;

namespace Database.Tests
{

    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        public void TestDatabaseCapacity()
        {
            Database database = new Database();

            for (int i = 1; i <= 16; i++)
            {
                database.Add(i);
            }
            
            Assert.Throws<InvalidOperationException>(
                () => database.Add(17), "Array's capacity must be exactly 16 integers!");
        }
        
        [Test]
        public void TestAddOperation()
        {
            Database database = new Database();
            database.Add(1);
            database.Add(2);

            int[] numbers = database.Fetch();

            Assert.That(numbers[1], Is.EqualTo(2), "");
        }
        
        [Test]
        public void TestRemoveOperation()
        {
            Database database = new Database();
            database.Add(1);
            database.Add(2);
            database.Add(3);
            database.Remove();

            int[] numbers = database.Fetch();

            Assert.That(numbers[1], Is.EqualTo(2), "");
            Assert.That(numbers[0], Is.EqualTo(1), "");
            Assert.That(numbers.Length, Is.EqualTo(2), "");
        }
        [Test]
        public void TestRemoveOperationWithEmptyDatabase()
        {
            Database database = new Database();
            

            Assert.Throws<InvalidOperationException>(
                () => database.Remove(), "The collection is empty!");
        }
        
        [Test]
        public void ConstructorEmptyCollectionReturnCountZero()
        {
            Database db = new Database();
            
            int actualResult = db.Count;
            int expectedResult = 0;

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void ConstructorWithThreeElementsReturnCountThree()
        {
            Database db = new Database(1, 2, 3);
            
            int actualResult = db.Count;
            int expectedResult = 3;

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void TestFetchWithTwoElements()
        {
            Database db = new Database(1, 2);
            
            int[] actualResult = db.Fetch();
            int[] expectedResult = new int[] {1, 2};

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
