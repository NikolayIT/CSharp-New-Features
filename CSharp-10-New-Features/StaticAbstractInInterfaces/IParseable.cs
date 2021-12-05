namespace StaticAbstractInInterfaces
{
    public interface IParseable<TSelf>
        where TSelf : IParseable<TSelf>
    {
        static abstract TSelf Parse(string s);

        static abstract bool TryParse(string s, out TSelf result);
    }
}
