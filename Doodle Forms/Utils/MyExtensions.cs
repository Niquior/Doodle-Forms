namespace Doodle_Forms.Utils
{
    public static class MyExtensions
    {
        public static string JoinIntoString(this byte[] bytes)
            => BitConverter.ToString(bytes).Replace("-", "").ToUpper();

        public static string[] ToStringArray(this Range range)
        {
            string[] indexes = new string[range.End.Value - range.Start.Value];
            for (int i = 0; i < indexes.Length; i++)
            {
                indexes[i] = i.ToString();
            }
            return indexes;
        }

        public static string[] GetIndexes(this Array array)
        {
            string[] indexes = new string[array.Length];
            for (int i = 0; i < indexes.Length; i++)
            {
                indexes[i] = i.ToString();
            }
            return indexes;
        }
    }
}
