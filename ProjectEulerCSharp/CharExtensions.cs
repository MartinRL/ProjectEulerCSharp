namespace ProjectEulerCSharp
{
    public static class CharExtensions
    {
        public static byte ParseAsByte(this char @this)
        {
            return byte.Parse(new string(new[] {@this}));
        }
    }
}
