using Microsoft.AspNetCore.Identity;

namespace TodoApp.Models
{
    public class Task
    {
        public int ID { get; set; }
        
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        public Task() {
        }
    }
}
