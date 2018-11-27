using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Threading;
using System.Diagnostics;

namespace CheckSumChecker
{
    class Hasher
    {
        //Byte Array
        byte[] hashValue;

        //Turns a Byte Array into a Hexadecimal string
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        public string HashSHA256(FileStream fileStream)
        {
            //Initialises a SHA256 object
            SHA256 mySHA256 = SHA256Managed.Create();

            //Compute the hash of the fileStream
            hashValue = mySHA256.ComputeHash(fileStream);

            //Turns Byte Array into hexidecimal string
            return ByteArrayToString(hashValue);
        }

        public string HashSHA1(FileStream fileStream)
        {
            SHA1 sha = new SHA1CryptoServiceProvider();
            hashValue = sha.ComputeHash(fileStream);
            return ByteArrayToString(hashValue);
        }

        public string HashSHA512(FileStream fileStream)
        {
            SHA512 mySHA512 = SHA512Managed.Create();
            hashValue = mySHA512.ComputeHash(fileStream);
            return ByteArrayToString(hashValue);
        }

        public string HashSHA384(FileStream fileStream)
        {
            SHA384 mySHA384 = SHA384Managed.Create();
            hashValue = mySHA384.ComputeHash(fileStream);
            return ByteArrayToString(hashValue);
        }

        public string HashMD5(FileStream fileStream)
        {
            MD5 myMD5 = new MD5CryptoServiceProvider();
            hashValue = myMD5.ComputeHash(fileStream);
            return ByteArrayToString(hashValue);
        }
    }
}
