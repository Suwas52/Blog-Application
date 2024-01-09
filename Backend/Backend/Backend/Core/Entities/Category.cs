namespace Backend.Core.Entities
{
    public class Category : BaseEntity
    {
        public string Category_Name { get; set; }

        public ICollection<Post> Posts { get; set; }

    }
}
