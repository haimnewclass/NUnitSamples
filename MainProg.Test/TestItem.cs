using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace MainProg.Test
{
    [TestFixture]
    public class TestItem
    {
        Items items = new Items();
        [SetUp]
        public void Init()
        {
            // initialize before all Tests
        }

        [Test]
        [Category ("UnitTest - Check Actions")]
        [Order (2) ]
        public void TestPlus()
        {
            //Items items = new Items();
            int ret = items.Plus(5, 5);

            // if ret == 10 Test Succeed
            // else Fail
            if (ret == 10)
            {
                Assert.AreEqual(10, ret, "The results is Good");
            }
            else
            {
                Assert.AreEqual(1, items.Minus(5, 5));
            }
        }


        [Test]
        [Order(1)]
        public void TestMinus()
        {
            
            int ret = items.Minus(5, 5);

            // if ret == 10 Test Succeed
            // else Fail

            //Assert.AreEqual(0, ret);
            Random rand = new Random();
            Random rand1 = new Random();
            rand1 = rand;
            // when referance type use Same
            // when value type use Equal
            Assert.AreSame(rand, rand1,"Random");
       
        }

        [Test ]
        public void TestMinus3()
        {

            int ret = items.Minus(5, 5);

            // if ret == 10 Test Succeed
            // else Fail

            Assert.That(ret, Is.InRange(-1,-1));        
        }

        [Test, Ignore("Have not finished yet")]
        [Order(1)]        
        
        public void TestMinus2()
        {+

            int ret = items.Minus(5, 5);

            // if ret == 10 Test Succeed
            // else Fail

            Assert.AreEqual(0, ret);
        }
    }

    
}
