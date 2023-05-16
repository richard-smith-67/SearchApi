namespace SearchApi.Dtos
{
    // Using a DTO to map to the test data format we've been given
    public class PersonDto
    {
        public int Id { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public string? email { get; set; }
        public string? gender { get; set; }
    }

}
