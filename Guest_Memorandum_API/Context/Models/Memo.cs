namespace Guest_Memorandum_API.Context.Models
{
    public class Memo : BaseEntity
    {
        public string Title { get; set; }

        public string Content { get; set; }
    }
}