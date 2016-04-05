namespace SingleResponsability.Good
{
    public class UserInfo
    {

        private User _user;

        public UserInfo(User user)
        {
            _user = user;
        }

        public bool IsValid()
        {
            bool isValid = false;
            return isValid;
        }


        public int GetAge()
        {
            int age = 0;
            return age;
        }
    }
}
