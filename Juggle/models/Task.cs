using System.ComponentModel.DataAnnotations;

namespace Juggle.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set;}
        public string Description { get; set;}
        public string Type { get; set;}

        public ICollection<TaskDependency> TaskDependencies { get; set;}

      

    }


     
}
