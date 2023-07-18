namespace MapApplication.Models
{
    public class UserDto
    {
        public required string UserName { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Password { get; set; }
        public required DateTime BirthDate { get; set; }
    }
}
