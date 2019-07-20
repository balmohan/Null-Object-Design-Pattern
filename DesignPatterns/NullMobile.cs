namespace DesignPatterns
{
    internal class NullMobile:IMobile
    {
        private static NullMobile _instance;
        private NullMobile()
        { }

        public static NullMobile Instance
        {
            get
            {
                if (_instance == null)
                    return new NullMobile();
                return _instance;
            }
        }

        //do nothing methods  
        public void TurnOff()
        { }

        public void TurnOn()
        { }
    }
}