using System.ComponentModel.DataAnnotations;

namespace EazyTodo.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }

        [Display(Name = "Completed")] 
        public bool IsDone { get; set; }

        [Required]
        public string? Title { get; set; }

        [Display(Name = "Due when")]
        public DateTimeOffset? DueAt { get; set; }
    }
}
