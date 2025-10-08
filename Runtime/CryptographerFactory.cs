namespace ActionCode.Cryptography
{
    /// <summary>
    /// Static factory class for <see cref="ICryptographer"/>.
    /// </summary>
    public static class CryptographerFactory
    {
        /// <summary>
        /// Creates an instance of <see cref="ICryptographer"/> based on the given type.
        /// </summary>
        /// <param name="type">The Cryptographer type to use.</param>
        /// <param name="key">The key to use with the Cryptographer.</param>
        /// <returns>An Cryptographer implementation.</returns>
        public static ICryptographer Create(CryptographerType type, string key) => type switch
        {
            CryptographerType.None => null,
            CryptographerType.AES => new AESCryptographer(key),
            _ => null,
        };
    }
}