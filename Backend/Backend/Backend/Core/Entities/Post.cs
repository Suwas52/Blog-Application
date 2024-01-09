namespace Backend.Core.Entities
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }

        public string Content { get; set; } 

        public int Aurthor_Id { get; set; }

        public User Aurthor { get; set; }

        public int Category_Id { get; set; }

        public Category Category { get; set; }

        public ICollection<Comment> Comments { get; set; } 

    }
}
