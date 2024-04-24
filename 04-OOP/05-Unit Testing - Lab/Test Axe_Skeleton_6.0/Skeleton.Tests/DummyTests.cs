using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);
            
            axe.Attack(dummy);
            
            Assert.That(dummy.Health, Is.EqualTo(0), "");
        }
        
        [Test]
        public void DeadDummyThrowsAnExceptionIfAttacked()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);
            
            axe.Attack(dummy);
            
            Assert.Throws<InvalidOperationException>(
                () => dummy.TakeAttack(0), "Dummy is dead.");
        }
        
        [Test]
        public void DeadDummyCanGiveXp()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);
            
            axe.Attack(dummy);
            
            var exp = dummy.GiveExperience();
            Assert.That(exp, Is.EqualTo(10), "Target is not dead.");
        }
        
        [Test]
        public void AliveDummyCantGiveXp()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);
            
            Assert.Throws<InvalidOperationException>(
                () => dummy.GiveExperience(), "Dummy is not dead.");
        }
    }
}