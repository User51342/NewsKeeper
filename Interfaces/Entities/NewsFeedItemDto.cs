namespace NewsKeeper.Interfaces.Entities
{
 public   class NewsFeedItemDto : INewsFeedItemDto
    {
        public INewsFeedAboDto NewsFeedAbo { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}
