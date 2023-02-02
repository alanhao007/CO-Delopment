namespace AdminPanel.Models
{
    public class Managers : Interface
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ManagerPicPath { get; set; }
        public ICollection<FileTeach> ManagerPictures { get; set; }

        public Managers()
        {
            ManagerPictures = new List<FileTeach>();
        }
}
}
