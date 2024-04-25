using System;
using NUnit.Framework;


using ExtendedDatabase;

namespace DatabaseExtended.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        [Test]
        public void TestCreatePersonSuccess()
        {
            Person person = new Person(1, "TestName");

            var actualResult = person.UserName;
            var expectedResult = "TestName";

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCreateDatabaseSuccess()
        {
            Person person = new Person(1, "TestName");
            Database db = new Database(person);

            var actualResult = db.Count;
            var expectedResult = 1;

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCreateDatabaseWith17Length()
        {
            Assert.Throws<ArgumentException>(
                () => new Database(new Person[17]),
                "Provided data length should be in range [0..16]!");
        }

        [Test]
        public void TestAddToDatabaseSuccess()
        {
            Person person = new Person(1, "TestName1");
            Database db = new Database();

            db.Add(person);

            var actualResult = db.Count;
            var expectedResult = 1;

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestAddToDatabaseWithExistingUsername()
        {
            Person person1 = new Person(1, "TestName");
            Person person2 = new Person(2, "TestName");
            Database db = new Database();

            db.Add(person1);
            Assert.Throws<InvalidOperationException>(
                () => db.Add(person2),
                "There is already user with this username!");
        }
        
        [Test]
        public void TestAddToDatabaseWithExistingId()
        {
            Person person1 = new Person(1, "TestName1");
            Person person2 = new Person(1, "TestName2");
            Database db = new Database();

            db.Add(person1);
            Assert.Throws<InvalidOperationException>(
                () => db.Add(person2),
                "There is already user with this Id!");
        }
        
        [Test]
        public void TestRemoveSuccess()
        {
            Person person1 = new Person(1, "TestName1");
            Person person2 = new Person(2, "TestName2");
            Database db = new Database();

            db.Add(person1);
            db.Add(person2);
            
            db.Remove();
            
            var actualResult = db.Count;
            var expectedResult = 1;
            
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void TestRemoveFromEmptyDb()
        {
            Database db = new Database();
            
            Assert.Throws<InvalidOperationException>(
                () => db.Remove(),
                "Operation is not valid due to the current state of the object.");
        }
        
        [Test]
        public void TestFindByUsernameSuccess()
        {
            Person person1 = new Person(1, "TestName1");
            Person person2 = new Person(2, "TestName2");
            Database db = new Database();

            db.Add(person1);
            db.Add(person2);
            
            var actualResult = db.FindByUsername("TestName1");
            var expectedResult = person1;
            
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void TestFindByUsernameWithNoExistingUser()
        {
            Person person1 = new Person(1, "TestName1");
            Person person2 = new Person(2, "TestName2");
            Database db = new Database();

            db.Add(person1);
            db.Add(person2);
            
            Assert.Throws<InvalidOperationException>(
                () => db.FindByUsername("TestName3"),
                "No user is present by this username!");
        }
        
        [Test]
        public void TestFindByUsernameWithNullUsername()
        {
            Person person1 = new Person(1, "TestName1");
            Person person2 = new Person(2, "TestName2");
            Database db = new Database();

            db.Add(person1);
            db.Add(person2);
            
            Assert.Throws<ArgumentNullException>(
                () => db.FindByUsername(null),
                "Username parameter is null!");
        }
        [Test]
        public void TestFindByUsernameWithWrongCase()
        {
            Person person1 = new Person(1, "TestName1");
            Person person2 = new Person(2, "TestName2");
            Database db = new Database();

            db.Add(person1);
            db.Add(person2);
            
            Assert.Throws<InvalidOperationException>(
                () => db.FindByUsername("testname2"),
                "No user is present by this username!");
        }
        
        [Test]
        public void TestFindByIdSuccess()
        {
            Person person1 = new Person(1, "TestName1");
            Person person2 = new Person(2, "TestName2");
            Database db = new Database();

            db.Add(person1);
            db.Add(person2);
            
            var actualResult = db.FindById(1);
            var expectedResult = person1;
            
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void TestFindByIdWithNoExistingId()
        {
            Person person1 = new Person(1, "TestName1");
            Person person2 = new Person(2, "TestName2");
            Database db = new Database();

            db.Add(person1);
            db.Add(person2);
            
            Assert.Throws<InvalidOperationException>(
                () => db.FindById(3),
                "No user is present by this ID!");
        }
        [Test]
        public void TestFindByIdWithNegativeId()
        {
            Person person1 = new Person(1, "TestName1");
            Person person2 = new Person(2, "TestName2");
            Database db = new Database();

            db.Add(person1);
            db.Add(person2);
            
            Assert.Throws<ArgumentOutOfRangeException>(
                () => db.FindById(-1),
                "Id should be a positive number!");
        }
    }
}