using System;
using System.Security.Cryptography;

namespace DataEncryption.KeyGenerator
{
    /// <summary>
    /// this class provides random key to use for encryption
    /// </summary>
    public  class CryptographicKeyGenerator
    {
        #region Variable declaration

       
        /// <summary>
        /// Keylenght is the variable which is defaulted in ctor ! it can always be altered
        /// </summary>
        public int KeyLengith { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// ctor also used to initialize keylenght
        /// </summary>
        public CryptographicKeyGenerator()
        {
            KeyLengith = 8;
        }
        #endregion

        #region bytecodewithzeros

     
        /// <summary>
        /// generate a base 64 string from the random bytes generated
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetEncryptionKey(int key)
        {
            return Convert.ToBase64String(GetBytesForKey(key));
        }
        /// <summary>
        /// this uses system.secure cryptographic byte random genrratin 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private byte[] GetBytesForKey(int key)
        {
            var rngUtility = new RNGCryptoServiceProvider();
            var randomBytes = new byte[key];
            rngUtility.GetBytes(randomBytes);
            return randomBytes;
        }
        #endregion
        #region ByteCodeWithOutZeros

       
        /// <summary>
        /// generate a base 64 string from the random bytes generated with out zeros
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetEncryptionKeyExcludingZeroBytes(int key)
        {
            return Convert.ToBase64String(GetBytesForKey(key));
        }
        /// <summary>
        /// this uses system.secure cryptographic byte random genrratin 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private byte[] GetBytesForKeyWithoutZeros(int key)
        {
            var rngUtility = new RNGCryptoServiceProvider();
            var randomBytes = new byte[key];
            rngUtility.GetNonZeroBytes(randomBytes);
            return randomBytes;
        }
        #endregion
    }
}
