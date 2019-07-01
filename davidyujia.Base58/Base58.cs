using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace davidyujia.Base58
{
    public sealed class Base58
    {
        private static readonly char[] base58Table = {
            '1','2','3','4','5','6','7','8','9',
            'A','B','C','D','E','F','G','H','J',
            'K','L','M','N','P','Q','R','S','T',
            'U','V','W','X','Y','Z','a','b','c',
            'd','e','f','g','h','i','j','k','m',
            'n','o','p','q','r','s','t','u','v',
            'w','x','y','z' };

        public static string Encode(byte[] data)
        {
            var sum = data.Aggregate<byte, BigInteger>(0, (current, b) => current * 256 + b);

            var sb = new StringBuilder();
            do
            {
                sum = BigInteger.DivRem(sum, 58, out var remainder);
                sb.Append(base58Table[(int)remainder]);
            } while (sum != 0);

            return new string(sb.ToString().Reverse().ToArray());
        }

        public static byte[] Decode(string encryptedString)
        {
            var sum = encryptedString.ToArray().Aggregate<char, BigInteger>(0, (current, c) => (current * 58) + Array.IndexOf(base58Table, c));

            var bit8 = 0;
            var list = new List<byte>();
            do
            {
                var twoPower = BigInteger.Pow(2, 8 * bit8++);
                var remainder = sum % (twoPower * 256);
                var quotient = remainder / twoPower;
                sum -= remainder;
                list.Add((byte)quotient);
            } while (sum != 0);
            list.Reverse();
            return list.ToArray();
        }
    }
}
