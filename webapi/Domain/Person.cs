namespace webapi.Domain
{
    // Ultimately this is what we would persist to the database via Entity Framework
    public class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
    }

}
