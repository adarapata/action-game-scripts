using UnityEngine;
using System.Collections;
using NUnit.Framework;
using Game.Base;
using UniRx;

namespace Game.Tests.Base
{
    [TestFixture]
    [Category("LifeTest")]
    public class LifeTest
    {
        [Test]
        public void LifeOverStreamTest()
        {
            Life life = new Life(10);
            life.lifeOverStream.Subscribe(l => {
                Assert.LessOrEqual(l, 0);
            });
            life.Damage(15);
        }
    }
}