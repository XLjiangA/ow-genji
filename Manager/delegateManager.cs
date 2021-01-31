namespace ow.manager
{
    public enum dataType
    {
        front,
        loop,
        cenkey,
        dirkey,
        mspeed,
        gmspeed,
        dir
    }
    public static class delegateManager
    {
        public delegate void valueUpdataDelegate(dataType data, object newvalue);

    }

}