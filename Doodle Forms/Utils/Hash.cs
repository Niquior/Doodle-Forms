using Org.BouncyCastle.Crypto.Digests;
using System.Text;

namespace Doodle_Forms.Utils
{
    internal readonly struct Hash(string value, string salt)
    {
        public byte[] Bytes { get; } = CalculateHash(value, salt);

        /// <returns>A hexadecimal uppercase string without hyphens.</returns>
        public override string ToString() => Bytes.JoinIntoString();

        private static byte[] CalculateHash(string value, string salt)
        {
            var sha3Digest = new Sha3Digest(256);
            byte[] bytes = Encoding.UTF8.GetBytes(value + salt);
            sha3Digest.BlockUpdate(bytes, 0, bytes.Length);
            byte[] result = new byte[sha3Digest.GetDigestSize()];
            sha3Digest.DoFinal(result, 0);
            return result;
        }
    }
}
