using System.ComponentModel.DataAnnotations;

namespace Backend.Core.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime Created_At { get; set; } = DateTime.Now;

        public DateTime Updated_At { get; set; }
    }
}
