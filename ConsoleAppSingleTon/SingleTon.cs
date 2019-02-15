namespace ConsoleAppSingleTon
{
    public class SingleTon
    {
        private static SingleTon _singleTonInstance = null;

        private int increment = -1;

        private SingleTon() { }

        public static SingleTon GetInstance()
        {
            if (_singleTonInstance != null)
            {
                return _singleTonInstance;
            }
            else
            {
                _singleTonInstance = new SingleTon();
                return _singleTonInstance;
            }
        }

        public int GetIncrement()
        {
            return ++increment;
        }
    }
}
