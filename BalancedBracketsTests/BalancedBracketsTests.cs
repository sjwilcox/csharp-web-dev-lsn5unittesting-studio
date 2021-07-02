using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void TestWithBrackets()
        {
             Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        [TestMethod]
        public void TestWithOpenBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
            
        }
        [TestMethod]
        public void TestWithEmptyStr()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void TestWithStrAndNoBracs()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("this is a test"));
        }
        [TestMethod]
        public void TestWithCloseBrac()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }
        [TestMethod]
        public void TestClosedBracBeforeOpen()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }
        [TestMethod]
        public void TestIsNotNullStr()
        {
            string str = "[check]";
            Assert.IsNotNull(BalancedBrackets.HasBalancedBrackets(str));
            
        }
        [TestMethod]
        public void TestStringWithBracs()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }
        [TestMethod]
        public void TestTooManyBracs()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("too[[many] brackets"));
        }
        [TestMethod]
        public void TestManyPairs()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[this] is a [test]"));
        }
        public void TestBooleanValueTrue()
        {
            Assert.AreEqual<bool>(true, BalancedBrackets.HasBalancedBrackets("[]"));
        }
        [TestMethod]
        public void TestBooleanVaueFalse()
        {
            Assert.AreEqual<bool>(false, BalancedBrackets.HasBalancedBrackets("LaunchC[ode"));
        }
        
       
    }
}
