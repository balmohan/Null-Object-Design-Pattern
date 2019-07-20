using System;

namespace DesignPatterns
{
    public class MobileRepository
    {
        public MobileRepository()
        {
        }

        internal IMobile GetMobileByName(string v)
        {
            IMobile mobile=NullMobile.Instance;
            switch (v)
            {
                case "sony":
                    mobile = new SonyXperia();
                    break;

                case "apple":
                    mobile = new AppleIPhone();
                    break;

                case "samsung":
                    mobile = new SamsungGalaxy();
                    break;
            }
            return mobile;
        }
    }
}