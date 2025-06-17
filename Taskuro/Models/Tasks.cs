using SQLite;

namespace Taskuro.Models
{
    public class Tasks
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? Priority { get; set; } 
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? DueDate { get; set; }
        public bool IsCompleted { get; set; } = false;
        public string? Category { get; set; }
        public string? Tags { get; set; } 
        public string? Notes { get; set; } 
        public string? Status { get; set; } 
        public string? AssignedTo { get; set; } 

    }
}
