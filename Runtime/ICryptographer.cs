using UnityEngine;

namespace OneM.Cryptography
{
    /// <summary>
    /// Interface used on objects able to encrypt and decrypt strings.
    /// </summary>
    public interface ICryptographer
    {
        /// <summary>
        /// Encrypts the given value.
        /// </summary>
        /// <param name="value">A string to encrypt.</param>
        /// <returns>An asynchronous operation of the encrypting process containing a non human readable string.</returns>
        Awaitable<string> EncryptAsync(string value);

        /// <summary>
        /// Decrypts the given value.
        /// </summary>
        /// <param name="value">A string to decrypt.</param>
        /// <returns>An asynchronous operation of the decrypting process containing a human readable string.</returns>
        Awaitable<string> DecryptAsync(string value);
    }
}