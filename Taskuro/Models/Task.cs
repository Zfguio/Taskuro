using SQLite;

namespace Taskuro.Models
{
    public class Task
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }

    }
}
