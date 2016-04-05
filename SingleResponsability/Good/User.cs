using System;

namespace SingleResponsability.Good
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public Guid UserId { get; set; }
    }
}
