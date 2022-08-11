using System;
namespace homework111
{
    public class User
    {
        string _password;
        string _userName;
        
    
    public string UserName {
        get
        {
            return (_userName);


        }
            set
            {
                if (value.Length >= 6 && value.Length <= 25)
                {
                    UserName = value;


                }
            
            }


    }
}
    public string Password
    {
        get
        {
            return (_password);

        }
        set
        {
            if(value.Length>= 8 && value.Length<=25 && HasDigit(value) && HasUpper (value) && Haslower(value))
            {
                Password = value;
            }


        }
    