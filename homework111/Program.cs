using System;

namespace homework111
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            User Usertype = new User("wertydfghj");
            Usertype.Password = "Azerbaycan";
            Usertype.ShowProfile();
        }
    }
}
