using System;

namespace NewsFeed.SQLDataAccess.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
