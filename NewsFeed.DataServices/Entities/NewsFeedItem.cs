using System.ComponentModel.DataAnnotations.Schema;

namespace NewsKeeper.SQLDataAccess.Entities
{
    [Table("NewsFeedItem")]
    public class NewsFeedItem : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

    }
}
