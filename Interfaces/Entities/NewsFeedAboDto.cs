using System;
using System.Collections.Generic;

namespace NewsKeeper.Interfaces.Entities
{
   public class NewsFeedAboDto : INewsFeedAboDto
    {
        public int Id { get; set; }
        public string FeedName { get; set; }
        public string Description { get; set; }
        public string FeedUrl { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<INewsFeedItemDto> NewsItems { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
