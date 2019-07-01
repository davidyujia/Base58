using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace davidyujia.Base58.Tests
{
    [TestClass]
    public class Base58Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testString = "Hello";

            var bytes = Encoding.UTF8.GetBytes(testString);

            var encode = davidyujia.Base58.Base58.Encode(bytes);

            Assert.AreEqual("9Ajdvzr", encode);
        }

        [TestMethod]
        public void TestMethod2()
        {
            for (var i = 0; i < 1000; i++)
            {
                var testString = GetRandomString(i);

                var bytes = Encoding.UTF8.GetBytes(testString);

                var encode = davidyujia.Base58.Base58.Encode(bytes);

                var decode = davidyujia.Base58.Base58.Decode(encode);

                var str = Encoding.UTF8.GetString(decode);

                Assert.AreEqual(testString, str);
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            for (var i = 0; i < 100000; i++)
            {
                var testString = GetRandomString(i);

                var bytes = Encoding.UTF8.GetBytes(testString);

                var encode = davidyujia.Base58.Base58.Encode(bytes);

                var decode = davidyujia.Base58.Base58.Decode(encode);

                var str = Encoding.UTF8.GetString(decode);

                Assert.AreEqual(testString, str);
            }
        }

        public static string GetRandomString(int length)
        {
            var str = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var next = new Random();
            var builder = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                builder.Append(str[next.Next(0, str.Length)]);
            }
            return builder.ToString();
        }
    }
}
