using System;

namespace ContactTypes
{
    public class ContactDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FulName => $"{FirstName} {LastName}";
    }
}
