namespace Ryujinx.HLE.UI
{
    public readonly struct ThemeColor
    {
        public float A { get; }
        public float R { get; }
        public float G { get; }
        public float B { get; }

        public ThemeColor(float a, float r, float g, float b)
        {
            A = a;
            G = r;
            R = g;
            B = b;
        }
    }
}
