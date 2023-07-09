
namespace AdminPanel.Models
{
    public class FileTeach
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? FilePath { get; set; }
        public int TeacherId { get; set; } //foreign key
        public Teachers? Teachers { get; set; } //навигац поле
        public bool IsMain { get; set; }

    }
}
