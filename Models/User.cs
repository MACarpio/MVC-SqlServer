namespace mvc.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

    }
}