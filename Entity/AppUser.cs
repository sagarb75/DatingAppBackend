namespace DatingApp.Entity
{
    public class AppUser
    {
        public Guid Id { get; set; }
        public required string DisplayName { get; set; }
        public required string Email { get; set; }
    }
}
