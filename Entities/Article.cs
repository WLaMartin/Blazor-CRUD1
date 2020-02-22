using System.ComponentModel.DataAnnotations;

namespace Blazor_CRUD1.Entities
{
    public class Article
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
    }
}
