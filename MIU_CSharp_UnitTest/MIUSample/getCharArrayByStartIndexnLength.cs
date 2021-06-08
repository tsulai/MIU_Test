using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MIU_CSharp_Class;

namespace MIU_CSharp_UnitTest
{
    //[TestClass]
    public class getCharArrayByStartIndexnLength
    {
        [TestMethod]
        public void TestMethod1()
        {
            char[] ans ;
            int start = 0;
            int len = 4;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getCharArrayByStartIndexnLength(new char[] {'a','b','c'},  start, len);
            // CollectionAssert
            CollectionAssert.AreEqual(ans, null);            
        }
       [TestMethod]
        public void TestMethod2()
        {
            char[] ans ;
            const int start = 0;
            const int len = 3;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getCharArrayByStartIndexnLength(new char[] { 'a', 'b', 'c' }, start, len);
            // Assert
            CollectionAssert.AreEqual(ans, new char[] { 'a','b','c'});

        }
    [TestMethod]
        public void TestMethod3()
        {
            char[] ans ;
            const int start = 0;
            const int len = 2;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getCharArrayByStartIndexnLength(new char[] { 'a', 'b', 'c' }, start, len);
            // Assert
            CollectionAssert.AreEqual(ans, new char[] { 'a', 'b'});
        }
       [TestMethod]
        public void TestMethod4()
        {
            char[] ans ;
            const int start = 0;
            const int len = 1;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getCharArrayByStartIndexnLength(new char[] { 'a', 'b', 'c' }, start, len);
            // CollectionAssert
            CollectionAssert.AreEqual(ans, new char[] { 'a' });
        }
       [TestMethod]
        public void TestMethod5()
        {
            char[] ans ;
            const int start = 1;
            const int len = 3;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getCharArrayByStartIndexnLength(new char[] { 'a', 'b', 'c' }, start, len);
            // CollectionAssert
            CollectionAssert.AreEqual(ans, null);
        }
        [TestMethod]
        public void TestMethod6()
        {
            char[] ans ;
            const int start = 1;
            const int len = 2;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getCharArrayByStartIndexnLength(new char[] { 'a', 'b', 'c' }, start, len);
            // CollectionAssert
            CollectionAssert.AreEqual(ans, new char[] { 'b', 'c' });

        }
       [TestMethod]
        public void TestMethod7()
        {
            char[] ans ;
            const int start = 1;
            const int len = 1;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getCharArrayByStartIndexnLength(new char[] { 'a', 'b', 'c' }, start, len);
            // CollectionAssert
            CollectionAssert.AreEqual(ans, new char[] { 'b' });

        }
        [TestMethod]
        public void TestMethod8()
        {
            char[] ans ;
            const int start = 2;
            const int len = 2;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getCharArrayByStartIndexnLength(new char[] { 'a', 'b', 'c' }, start, len);
            // CollectionAssert
            CollectionAssert.AreEqual(ans, null);

        }
       [TestMethod]
        public void TestMethod9()
        {
            char[] ans ;
            const int start = 2;
            const int len = 1;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getCharArrayByStartIndexnLength(new char[] { 'a', 'b', 'c' }, start, len);
            // CollectionAssert
            CollectionAssert.AreEqual(ans, new char[] { 'c' });

        }
        [TestMethod]
        public void TestMethod10()
        {
            char[] ans ;
            const int start = 3;
            const int len = 1;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getCharArrayByStartIndexnLength(new char[] { 'a', 'b', 'c' }, start, len);
            // CollectionAssert
            CollectionAssert.AreEqual(ans, null);

        }
        [TestMethod]
        public void TestMethod11()
        {
            char[] ans ;
            const int start = 1;
            const int len = 0;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getCharArrayByStartIndexnLength(new char[] { 'a', 'b', 'c' }, start, len);
            // CollectionAssert
            CollectionAssert.AreEqual(ans, new char[] { });

        }
        [TestMethod]
        public void TestMethod12()
        {
            char[] ans ;
            const int start = -1;
            const int len = 2;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getCharArrayByStartIndexnLength(new char[] { 'a', 'b', 'c' }, start, len);
            // CollectionAssert
            CollectionAssert.AreEqual(ans, null);

        }
       [TestMethod]
        public void TestMethod13()
        {
            char[] ans ;
            const int start = -1;
            const int len = -2;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getCharArrayByStartIndexnLength(new char[] { 'a', 'b', 'c' }, start, len);
            // CollectionAssert
            CollectionAssert.AreEqual(ans, null);

        }
        [TestMethod]
        public void TestMethod14()
        {
            char[] ans ;
            const int start = 0;
            const int len = 1;
            // Act
            ans = MIU_CSharp_Class.MIUSample.getCharArrayByStartIndexnLength(new char[] {  }, start, len);
            // CollectionAssert
            CollectionAssert.AreEqual(ans, null);

        }
    }
}
