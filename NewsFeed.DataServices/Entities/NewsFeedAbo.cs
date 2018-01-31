using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsFeed.SQLDataAccess.Entities
{
    [Table("NewsFeedAbos")]
    public class NewsFeedAbo : BaseEntity
    {
        public string FeedName { get; set; }
        public string Description { get; set; }
        public string FeedUrl { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }
        public virtual IEnumerable<NewsFeedItem> NewsFeedItems { get; set; }
    }
}
