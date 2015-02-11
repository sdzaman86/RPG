using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPG.Character;
using RPG.Character.Race;
using RPG.Equipment.Weapons.Martial;
using RPG.Character.Monster;

namespace RPGTest
{
    [TestClass]
    public class AttackTest
    {
        [TestMethod]
        public void AttackGT0()
        {
            AbstractCharacter c1 = new Human();
            AbstractCharacter c2 = new Human();

            int damage = c1.Attack(c2);
            Assert.AreNotEqual(0, damage);
        }

        [TestMethod]
        public void AttackTill0Health()
        {
            AbstractCharacter c1 = new Human();
            c1.RightHand = new ShortSword();
            AbstractCharacter c2 = new Human();

            while (c1.Health >= 0 && c2.Health >= 0)
            {
                c1.Attack(c2);
                c2.Attack(c1);
            }            
        }

        [TestMethod]
        public void HumanAndAngel()
        {
            AbstractCharacter c1 = new Human();
            c1.RightHand = new ShortSword();
            AbstractCharacter c2 = new Angel();
            c2.RightHand = new ShortSword();

            while (c1.Health >= 0 && c2.Health >= 0)
            {
                c1.Attack(c2);
                c2.Attack(c1);
            }

            Assert.IsTrue(c1.Health <= 0);
            Assert.IsTrue(c2.Health > 0);
        }
    }
}
