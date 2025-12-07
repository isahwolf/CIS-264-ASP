using System.ComponentModel.DataAnnotations;

namespace Exam4.Models
{
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? Completed { get; set; }
        public string Priority { get; set; }

    }
}
