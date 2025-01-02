using System.Security.Cryptography;

namespace Doodle_Forms.Utils
{
    public readonly struct Salt
    {
        public Salt() => RandomNumberGenerator.Fill(Bytes);

        public byte[] Bytes { get; } = new byte[32];

        /// <returns>A hexadecimal uppercase string without hyphens.</returns>
        public override string ToString() => Bytes.JoinIntoString();
    }
}
