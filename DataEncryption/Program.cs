using DataEncryption.KeyGenerator;
using System;

namespace DataEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Lets Generate Key!, Enter your keylengith below");
           TestKeyGen();
            Console.ReadKey();
        }
        private static void TestKeyGen()
        {
            if (!Console.NumberLock)
            {
                Console.WriteLine("Numb lock is off!");

            }
            var inputKey = Console.ReadLine();
            var keylengith = Convert.ToInt32(inputKey);
            var keyGen = new CryptographicKeyGenerator();
            keyGen.KeyLengith = keylengith;
            Console.WriteLine("Key generated with length given" + keyGen.GetEncryptionKey(keylengith));
        }
    }
}
