namespace Backend.Core.Entities
{
    public class Comment : BaseEntity
    {
        public int User_Id { get; set; }

        public User User { get; set; }

        public int Post_Id { get; set; }

        public Post Post { get; set; }

        public string Comment_Text { get; set; }    
    }
}
