namespace chef.DAL
{
    public static class Delegates
    {
        public delegate bool TryParseDelegate<T>(string input, out T output);
        public delegate string ConvertToStringDelegate<T>(T input);
    }
}
