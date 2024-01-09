using System.ComponentModel.DataAnnotations;

namespace Backend.Core.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public ICollection<Post> Posts { get; set; }

        public ICollection<Comment> Comments { get; set; }  

    }
}
